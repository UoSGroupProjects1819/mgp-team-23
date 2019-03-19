using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BaitSnap : MonoBehaviour
{
    bool snapped = false;
    GameObject trap;
    Vector3 offset;

    Update()
    {
        if (snapped == true)
        {
            transform.position = parent.transform.position + offset;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "trap")
        {
            snapped = true;
            trap = col.gameObject;
            offset = transform.position - trap.transform.position;
            Destroy(this.GetComponent<RigidBody>());
        }
    }
}