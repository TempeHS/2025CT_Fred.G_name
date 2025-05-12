

using UnityEngine;
using System.Collections;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float spawnInterval = 2f;

    private Camera cam;
    private float camWidth, camHeight;

    void Start()
    {
        cam = Camera.main;
        camHeight = 2f * cam.orthographicSize;
        camWidth = camHeight * cam.aspect;

        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            SpawnAsteroid();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnAsteroid()
    {
        Vector2 spawnPos = GetRandomEdgePosition();
        Instantiate(asteroidPrefab, spawnPos, Quaternion.identity); // no parenting
    }

    Vector2 GetRandomEdgePosition()
    {
        int edge = Random.Range(0, 4);
        float x = 0, y = 0;

        switch (edge)
        {
            case 0: x = -camWidth / 2; y = Random.Range(-camHeight / 2, camHeight / 2); break; // Left
            case 1: x = camWidth / 2; y = Random.Range(-camHeight / 2, camHeight / 2); break;  // Right
            case 2: y = camHeight / 2; x = Random.Range(-camWidth / 2, camWidth / 2); break;   // Top
            case 3: y = -camHeight / 2; x = Random.Range(-camWidth / 2, camWidth / 2); break;  // Bottom
        }

        return new Vector2(x, y);
    }
}
