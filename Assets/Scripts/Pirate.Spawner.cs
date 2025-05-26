using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [Header("Spawning Settings")]
    public GameObject objectToSpawn;

    [Tooltip("Average number of spawns per second")]
    public float spawnRate = 1f;

    [Tooltip("Random time factor (0 = fixed rate, 1 = up to 2x delay)")]
    [Range(0, 1)]
    public float randomTimeFactor = 0.5f;

    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    System.Collections.IEnumerator SpawnLoop()
    {
        while (true)
        {
            float baseDelay = 1f / spawnRate;
            float randomFactor = Random.Range(1f - randomTimeFactor, 1f + randomTimeFactor);
            float delay = baseDelay * randomFactor;

            yield return new WaitForSeconds(delay);
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        if (objectToSpawn != null)
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
        }
    }
}


