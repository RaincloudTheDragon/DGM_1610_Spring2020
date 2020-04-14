using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1;
    public int time = 3;

    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(DestroyBullet());
    }

    private void OnCollisionEnter(Collision other)
    {
        /*if (other.gameObject.CompareTag("Enemy"))
        {
            var hit = other.gameObject;
            var health = hit.GetComponent<EnemyHealth>();

            if (health != null)
            {
                health.TakeDamage(damage);
                Debug.Log("Ouch, you hit me!");
            }
        }*/
        var health = other.gameObject.GetComponent<EnemyHealth>();

        if(health != null)
        {
            health.TakeDamage(damage);
        }
    }

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(time);

        Destroy(gameObject);
    }

    //don't really need void update because we're cooler than it 😎
}
