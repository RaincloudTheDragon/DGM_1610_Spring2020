using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float horizontalInput;

    public float jumpHeight;
    public bool isGrounded;

    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move R and L
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime *horizontalInput);
        speed = 10;
    }

    // Try to get it in one...? Not sure why it doesn't like OnCollisionStay
    // void OnCollisionStay(Collider other)
    // {
    //     if(other.gameObject.CompareTag("Floor"))
    //     {
    //         isGrounded = true;
    //         Debug.Log("Grounded!");
    //     }

    //     else
    //     {
    //         Debug.Log("Not Grounded.");
    //     }
    // }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isGrounded = true;
            Debug.Log("Grounded!");
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isGrounded = false;
            Debug.Log("Not Grounded.");
        }
    }

    private void FixedUpdate()
    {
        //Jump
        if(Input.GetKeyDown("up") && isGrounded)
        {
            rb.AddForce(Vector3.up *jumpHeight * 1000 * Time.deltaTime);
        }
    }
}
