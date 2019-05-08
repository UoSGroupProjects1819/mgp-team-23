using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{

    float targetTime = 5.0f;
    public GameObject[] objectsToSpawn;
    public Transform[] spawnPoints; 

    public int spawnCount;
    public int spawnCycles;
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
            GameObject go = Instantiate(objectsToSpawn[objectIndex], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
        }

        spawnCycles++;

        switch (spawnCycles)
        {
            case 5:
                spawnCount = 2;
                break;
            case 10:
                spawnCount = 3;
                break;
            case 15:
                spawnCount = 4;
                break;
            case 25:
                spawnCount = 5;
                break;
            case 35:
                spawnCount = 6;
                break;
            case 60:
                spawnCount = 7;
                break;
            case 90:
                spawnCount = 8;
                break;
            case 150:
                spawnCount = 9;
                break;

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






