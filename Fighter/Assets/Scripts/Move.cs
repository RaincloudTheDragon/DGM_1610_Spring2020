using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float horizontalInput;

    public float jumpHeight;
    public bool isGrounded;

    // private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        // rb = GetComponent<RigidBody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move R and L
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime *horizontalInput);
        speed = 10;
    }

    // private void FixedUpdate()
    // {
    //     //Jump
    //     if(Input.GetKeyDown("up") && isGrounded)
    //     {
    //         rb.AddForce(Vector3.up *jumpHeight * 1000 * Time.deltaTime);
    //     }
    // }
}
