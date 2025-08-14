using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public float RockInterval = 5f;
    [SerializeField] private GameObject RockPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnRock(RockInterval, RockPrefab));
    }

    private IEnumerator spawnRock(float interval, GameObject rock)
    {
        yield return new WaitForSeconds(interval);
        GameObject newRock = Instantiate(rock, new Vector3(Random.Range(-5f, 7), Random.Range(-4f, 4), 0), Quaternion.identity);
        StartCoroutine(spawnRock(interval, rock));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
