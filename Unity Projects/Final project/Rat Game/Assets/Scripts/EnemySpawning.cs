using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{

    public GameObject ObjectToSpawn;
    public float RateOfSpawn = 1;
    private int MaxThrowables = 10;
    private int ThrowableCounter = 0;

    private float nextSpawn = 0;

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + RateOfSpawn;

            // Random position within this transform
            Vector3 rndPosWithin;
            rndPosWithin = new Vector3(Random.Range(-50f, 50f), Random.Range(-1f, 1f), Random.Range(-50f, 50f));
            rndPosWithin = transform.TransformPoint(rndPosWithin * .5f);
            if (ThrowableCounter < MaxThrowables)
                Instantiate(ObjectToSpawn, rndPosWithin, transform.rotation);
                ThrowableCounter++;
        }
    }
}



        

    


