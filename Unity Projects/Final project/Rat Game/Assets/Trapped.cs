using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapped : MonoBehaviour
{
    bool trapped = false;
    GameObject rat;


    void Update()
    {
       
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "rat")
        {
            trapped = true;
            rat = col.gameObject;
            Destroy(this.GetComponent<Rigidbody>());
        }
    }


}
