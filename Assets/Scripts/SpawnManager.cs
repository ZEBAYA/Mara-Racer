using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour

{
    public GameObject[] obstaclePrefabs; 
    public float minSpawnInterval = 5.0f;
    public float maxSpawnInterval = 10.0f;
    public float spawnInterval = 1.5f;
    public float initialDelay = 2.0f;

    private void Start()
    {
        InvokeRepeating("SpawnObstacle", initialDelay, Random.Range(minSpawnInterval, maxSpawnInterval));
    }

    private void SpawnObstacle()
    {
        int randomIndex = Random.Range(0, obstaclePrefabs.Length);
        GameObject obstaclePrefab = obstaclePrefabs[randomIndex];

        // Generate a random X-position within a specified range.
        float randomX = Random.Range(-33.0f, 6.0f); // Adjust the range as needed.

        // Instantiate the selected prefab at the random X-position with no rotation.
        Vector3 spawnPosition = new Vector3(randomX, transform.position.y, transform.position.z);
        Instantiate(obstaclePrefab, spawnPosition, transform.rotation * Quaternion.Euler(0, -90, 0));
    }
}

    


