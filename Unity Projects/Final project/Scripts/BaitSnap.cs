using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BaitSnap : MonoBehaviour
{
    bool snapped = false;
    GameObject trap;
    
    void Update()
    {
        if (snapped == true)
        {
            this.transform.SetParent(trap.transform);
            transform.position = this.transform.parent.position;
            transform.rotation = this.transform.parent.rotation;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "trap")
        {
            snapped = true;
            trap = col.gameObject;
            Destroy(this.GetComponent<Rigidbody>());
            Destroy(col.GetComponent<Rigidbody>());
        }
    }
}