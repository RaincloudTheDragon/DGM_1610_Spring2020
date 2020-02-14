using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float verticalInput;
    public float horizontalInput;
    public float turnSpeed;
    public float jumpSpeed;
    public float positionLock;

    public GameObject projectilePreFab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Forward and Backward movement
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        speed = 10;

        //Rotation
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        turnSpeed = 200;

        //Jump!
        jumpSpeed = 2;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * jumpSpeed);
        }

        //For his neutral special, joker wields GUN
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(projectilePreFab, transform.position, projectilePreFab.transform.rotation);
        }
    }
}
