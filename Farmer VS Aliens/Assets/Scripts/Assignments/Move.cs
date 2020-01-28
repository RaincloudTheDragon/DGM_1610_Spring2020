using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -.1f);
    }

    // Detect collision with another object
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Floor")) // Primary
        {
            Debug.Log("Colliding with floor");
        }
        else if (other.gameObject.CompareTag("Obstacle")) // Secondary
        {

        }
        else // Default
        {
            Debug.Log("...");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("you have entered the trigger zone!");
    }
}
