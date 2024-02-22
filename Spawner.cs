using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject stonePrefab;

    public float spawnRate = 2f;
    private float nextSpawnTime = 0f;

    public float fallSpeed = 5f;

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnObject();
            nextSpawnTime = Time.time + 1f / spawnRate;
        }
    }

    void SpawnObject()
    {
        GameObject spawnedObject = null;

        if (Random.Range(0f, 1f) < 0.5f)
        {
            spawnedObject = Instantiate(coinPrefab, transform.position, Quaternion.identity);
        }
        else
        {
            spawnedObject = Instantiate(stonePrefab, transform.position, Quaternion.identity);
        }

        Rigidbody2D rb = spawnedObject.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = new Vector2(0, -fallSpeed);
        }

        Destroy(spawnedObject, 5f);
    }
}
