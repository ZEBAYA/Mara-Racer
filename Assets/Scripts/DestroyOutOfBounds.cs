using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float destroyDistance = -9.0f; // The distance at which obstacles should be destroyed.

    void Update()
    {
<<<<<<< Updated upstream
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle"); // Assuming obstacles have the "Obstacle" tag.
=======
        private float backLimit = -8;
>>>>>>> Stashed changes

        foreach (var obstacle in obstacles)
        {
            float distance = Vector3.Distance(transform.position, obstacle.transform.position);

            if (distance > destroyDistance)
            {
                Destroy(obstacle); // Destroy the obstacle if it's beyond the destroyDistance.
            }
        }
    }

}