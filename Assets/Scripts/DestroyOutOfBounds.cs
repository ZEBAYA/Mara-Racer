using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public class DestroyOutOfBoundsX : MonoBehaviour
    {
        private float backLimit = -1;


        // Update is called once per frame
        void Update()
        {
            // Destroy obstacle if z position less than back limit
            if (transform.position.z < backLimit)
            {
                Destroy(gameObject);
            }
        }
    }
}