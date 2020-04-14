using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 3;
    public Transform spawnPoint;
    //how many points do we get for destroying this enemy?
    public int points = 10;

    // Start is called before the first frame update
    void Start()
    {
        //always start the game with max health!
        currentHealth = maxHealth;
        spawnPoint = GameObject.Find("SpawnPoint").transform;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            //keep score at zero
            currentHealth = 0;
            print("Enemy is dead!");
            //add points to score for killing enemy
            ScoreManager.AddPoints(points);
            //Move enemy from spawn point to restart
            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;
            //Reset enemy health
            currentHealth = maxHealth;
        }
    }
}
