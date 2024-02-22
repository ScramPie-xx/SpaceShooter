using UnityEngine;

public class Player : MonoBehaviour
{
    public int coinsCollected = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            CollectCoin(other.gameObject);
        }
        else if (other.CompareTag("Stone"))
        {
            DestroyPlayer();
        }
    }

    void CollectCoin(GameObject coin)
    {
        coinsCollected++;
        Destroy(coin);
    }

    void DestroyPlayer()
    {
        Destroy(gameObject);
    }
}
