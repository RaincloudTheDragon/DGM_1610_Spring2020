using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public int timeToDestroy;

    void Update()
    {
        Destroy(gameObject, timeToDestroy);
    }
}
