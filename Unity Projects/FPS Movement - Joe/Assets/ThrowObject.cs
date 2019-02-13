using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{

    public GameObject playerCamera;
    public GameObject player;
    public float throwStrength = 10;
    public bool held = true;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && held == true)
        {
            GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * throwStrength, ForceMode.Impulse);
            held = false;
        }
        if (Input.GetMouseButtonDown(1) && held == false)
        {
            held = true;
        }
    }
}
