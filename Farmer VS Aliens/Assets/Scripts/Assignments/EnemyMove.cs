using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject Player;
    //public Transform target;
    public float moveSpeed;
    private Rigidbody enemyRb;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
        //target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Transform
        //transform.LookAt(target);
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        //Add Force
        enemyRb.AddForce((Player.transform.position - transform.position).normalized * moveSpeed);

        //Velocity
    }
}
