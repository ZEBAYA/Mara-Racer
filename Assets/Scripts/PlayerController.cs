using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float horizontalInput;
    public float speed = 20.0f;
    private float leftRange=35.0f;
    private float rightRange= 7.5f;
    public Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //keeping player inbounds
        //left bound
        if(transform.position.x <-leftRange)
        {
            transform.position = new Vector3(-leftRange, transform.position.y, transform.position.z);
        }
        //right bound
        if(transform.position.x >-rightRange)
        {
            transform.position = new Vector3(-rightRange, transform.position.y, transform.position.z);
        }
    
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }   
}