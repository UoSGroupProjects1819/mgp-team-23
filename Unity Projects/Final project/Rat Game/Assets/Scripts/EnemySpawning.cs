using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{

    float targetTime = 5.0f;
    public GameObject[] objectsToSpawn;
    public Transform[] spawnPoints; 

    public int spawnCount; 
    private readonly int objectIndex = 0; 
    private int spawnIndex;

    void Update()
    {
        targetTime -= Time.deltaTime;
        
        if (targetTime <= 0.0f)
        {
            targetTime = 5.0f;
            TimerEnded();

        }


    }



    void TimerEnded()
    {
        for (int i = 0; i < spawnCount; i++)
        {

            spawnIndex = Random.Range(0, 3);


            GameObject go = Instantiate(objectsToSpawn[objectIndex], spawnPoints[spawnIndex].position, Quaternion.identity);
        }
    }



    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            Gizmos.DrawSphere(spawnPoints[i].position, 0.5f);
        }
    }
}






