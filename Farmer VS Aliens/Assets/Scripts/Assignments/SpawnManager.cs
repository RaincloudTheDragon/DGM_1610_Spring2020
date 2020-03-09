using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;

    //select which enemy will be spawned
    public int enemyIndex;

    // Start is called before the first frame update
    void Start()
    {
//        for (int i = 0;
//        {
//            Debug.Log("creating enemy number");
//        }
    }

    // Update is called once per frame
    void Update()
    {
        // Pick a random badguy...
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);

        if(Input.GetKeyDown(KeyCode.E)) //E for enemy
        {
            Instantiate(enemyPrefabs[enemyIndex], new Vector3(0, 0, 0), enemyPrefabs[enemyIndex].transform.rotation);
        }
    }
}
