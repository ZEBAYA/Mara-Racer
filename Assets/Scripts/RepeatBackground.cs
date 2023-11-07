using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    private void Start()
    {
        startPos = transform.position; // Establish the default starting position 

    }

    private void Update()
    {

         RepeatBackgroundv();
        // If background moves left by its repeat width, move it back to start position
        if (transform.position.z < startPos.z - repeatWidth)
        {
            transform.position = startPos;
        }
    }

    private void RepeatBackgroundv()
    {
         repeatWidth = GetComponent<BoxCollider>().size.y/ 1.4f; // Set repeat width to half of the background

    }

 
}


