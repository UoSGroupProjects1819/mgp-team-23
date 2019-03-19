using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RatKill : MonoBehaviour
{
    Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "trap" && col.snapped == true)
        {
            Destroy(this);
            Destroy(col);

			//Play confetti animation etc..
        }
    }
}