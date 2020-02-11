using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float verticalInput;
    public float horizontalInput;
    public float turnSpeed;
    public float jump;

    public GameObject projectilePreFab;

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

        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up);
        }

        if(Input.GetKeyDown(KeyCode.I))
        {
            Instantiate(projectilePreFab, transform.position, projectilePreFab.transform.rotation);
        }
    }

}
