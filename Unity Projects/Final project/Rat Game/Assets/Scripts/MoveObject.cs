using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{

    public GameObject item;
    public GameObject tempParent;
    public Transform guide;
    public float speed;
    public float rmbspeed;


    // Use this for initialization
    void Start()
    {
        item.GetComponent<Rigidbody>().useGravity = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().isKinematic = true;
            item.transform.position = guide.transform.position;
            item.transform.rotation = guide.transform.rotation;
            item.transform.parent = tempParent.transform;
        }
        if (Input.GetMouseButtonUp(0))
        {
            guide.GetChild(0).gameObject.GetComponent<Rigidbody>().velocity = transform.forward * speed;
            item.GetComponent<Rigidbody>().useGravity = true;
            item.GetComponent<Rigidbody>().isKinematic = false;
            item.transform.parent = null;
            item.transform.position = guide.transform.position;
        }

        if (Input.GetMouseButtonDown(1))
        {
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().isKinematic = true;
            item.transform.position = guide.transform.position;
            item.transform.rotation = guide.transform.rotation;
            item.transform.parent = tempParent.transform;
        }

        if (Input.GetMouseButtonUp(1))
        {
            guide.GetChild(0).gameObject.GetComponent<Rigidbody>().velocity = transform.forward * rmbspeed;
            item.GetComponent<Rigidbody>().useGravity = true;
            item.GetComponent<Rigidbody>().isKinematic = false;
            item.transform.parent = null;
            item.transform.position = guide.transform.position;
        }
    }
}


