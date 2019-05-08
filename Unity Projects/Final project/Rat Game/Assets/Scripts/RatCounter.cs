using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatCounter : MonoBehaviour
{
    public GameObject[] ratList;
    public static int ratCount;



    void Update()
    {
        ratList = GameObject.FindGameObjectsWithTag("rat");
        ratCount = ratList.Length;
    }
}
