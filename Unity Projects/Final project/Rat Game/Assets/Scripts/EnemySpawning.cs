using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public Transform spawnPosition;
    public GameObject ObjectToSpawn;
    public float RateOfSpawn = 1;
    private int MaxThrowables = 3;
    private int ThrowableCounter = 0;

    private float nextSpawn = 0;

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + RateOfSpawn;

            if (ThrowableCounter < MaxThrowables) ;
                Instantiate(ObjectToSpawn, spawnPosition.position, ObjectToSpawn.transform.rotation);
            ThrowableCounter++;
 
        }
    }
}



        

    


