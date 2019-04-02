using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{

    public GameObject tempParent;
    public Transform guide;
    public float speed;
    public float rmbspeed;
    private bool clicked = false;
    private GameObject item;

    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider != null & (hit.collider.gameObject.tag == "item" || hit.collider.gameObject.tag == "trap"))
                {

                    if(hit.collider.gameObject.tag == "trap")
                    {
                        hit.collider.gameObject.tag = "heldtrap";
                    }
                    item = hit.collider.gameObject;

                    clicked = true;
                    item.GetComponent<Rigidbody>().useGravity = false;
                    item.GetComponent<Rigidbody>().isKinematic = true;
                    item.transform.position = guide.transform.position;
                    item.transform.rotation = guide.transform.rotation;
                    item.transform.parent = tempParent.transform;                  
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            clicked = false;
            guide.GetChild(0).gameObject.GetComponent<Rigidbody>().velocity = transform.forward * speed;
            item.GetComponent<Rigidbody>().useGravity = true;
            item.GetComponent<Rigidbody>().isKinematic = false;
            item.transform.parent = null;
            item.transform.position = guide.transform.position;

            if (item.gameObject.tag == "heldtrap")
            {
                item.gameObject.tag = "trap";
            }


        }

        if (Input.GetMouseButtonDown(2))
        {
            clicked = false;
            guide.GetChild(0).gameObject.GetComponent<Rigidbody>().velocity = transform.forward * rmbspeed;
            item.GetComponent<Rigidbody>().useGravity = true;
            item.GetComponent<Rigidbody>().isKinematic = false;
            item.transform.parent = null;
            item.transform.position = guide.transform.position;


            if (item.gameObject.tag == "heldtrap")
            {
                item.gameObject.tag = "trap";
            }
        }
    }
}



