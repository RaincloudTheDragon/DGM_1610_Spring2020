using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class Wander : MonoBehaviour
{
    // Wander
    public float wanderRadius;
    public float wanderTimer;

    public Transform target;
    private UnityEngine.AI.NavMeshAgent agent;
    private float timer;

    // Detection
    public float speed;
    public float alertDist;
    public float attackDist;
    private float distance;

    private Vector3 heading;
    // Attack
    public int damage;

    // Use this for initialization
    void OnEnable()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        timer = wanderTimer;
    }

    void Start()
    {
        distance = Vector3.Distance(target.position, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(target.position, transform.position);

        // Alert
        if(distance < alertDist && distance > attackDist)
        {
            print("Enemy sees target");
            speed += 2;
            transform.LookAt(target);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        // Following
        else if(distance <= alertDist)
        {
            print("Enemy is Following");
            heading = target.position - transform.position;
            heading.y = 0;
            speed -= 10;
            transform.LookAt(target);
            transform.Translate(Vector3.forward * speed *Time.deltaTime);

            if(heading.magnitude <= attackDist)
            {
                print("Enemy is attacking");
                var health = target.gameObject.GetComponent<PlayerHealth>();

                if (health != null)
                {
                    health.TakeDamage(damage);
                }
            }
        }

        // Wandering
        else if(distance > alertDist)
        {
            timer += Time.deltaTime;

            if(timer >= wanderTimer)
            {
                Vector3 newPos = RandomNavSphere (transform.position, wanderRadius, -1);
                agent.SetDestination(newPos);
                timer = 0;
            }
        }
    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        UnityEngine.AI.NavMeshHit navHit;

        UnityEngine.AI.NavMesh.SamplePosition (randDirection, out navHit, dist, layermask);

        return navHit.position;
    }
}