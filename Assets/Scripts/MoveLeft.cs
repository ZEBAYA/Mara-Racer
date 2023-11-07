using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    public float speed;
   
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // If game is not over, move to the left
            transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);

        // If object goes off screen that is NOT the background, destroy it


    }
}
