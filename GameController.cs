using UnityEngine;

public class GameController : MonoBehaviour
{
    private bool isDragging = false;
    private Vector2 touchStartPosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartDragging();
        }

        if (Input.GetMouseButtonUp(0))
        {
            StopDragging();
        }

        if (isDragging)
        {
            ContinueDragging();
        }
    }

    void StartDragging()
    {
        isDragging = true;
        touchStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void StopDragging()
    {
        isDragging = false;
    }

    void ContinueDragging()
    {
        Vector2 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 movement = currentPosition - touchStartPosition;

        touchStartPosition = currentPosition;
    }
}
