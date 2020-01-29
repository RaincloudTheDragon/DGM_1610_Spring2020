using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float verticalInput;
    public float horizontalInput;
    public float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        // (0, 0, -0.1f)
    }

// Detect collision with another object
// void OnCollisionEnter(Collision other)
//    {

//      if (other.gameObject.CompareTag("Floor")) // Primary
//        {
//          Debug.Log("Colliding with floor");
//    }
//  else if (other.gameObject.CompareTag("Obstacle")) // Secondary
//        {
//
//      }
//    else // Default
//  {
//    Debug.Log("...");
//        }
//  }
//void OnTriggerEnter(Collider other)
//{
//        Debug.Log("you have entered the trigger zone!");
//}
}
