using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatRoad : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
         startPos = transform.position; // Establish the default starting position 
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < startPos.z - repeatWidth)
        {
            transform.position = startPos;
        }
        RepeatRoadr();
    }
     private void RepeatRoadr()
    {
         repeatWidth = GetComponent<BoxCollider>().size.z; // Set repeat width to half of the background

    }
}
