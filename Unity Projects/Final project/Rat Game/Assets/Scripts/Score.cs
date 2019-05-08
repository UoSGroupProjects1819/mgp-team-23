using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("rat").GetComponent<RatMovement>().score -= 0;
    }

    void Update()
    {
        


    }
}
