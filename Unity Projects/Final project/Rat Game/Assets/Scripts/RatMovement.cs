using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatMovement : MonoBehaviour
{
    public int movementSpeed = 10;
    public float ratTurnTime = 2.0f;
    private float turnTime = 0.0f;
    private bool turnRight = false;
    private GameObject[] baitedTraps;

    bool trappedRat = false;
    GameObject trap;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        baitedTraps = GameObject.FindGameObjectsWithTag("baitedtrap");

        transform.position += transform.right * Time.deltaTime * movementSpeed;
        turnTime -= Time.deltaTime;
        float ranNumber = Random.value;


        if (baitedTraps.Length < 1)
        {
            if (turnTime <= 0.0f)
            {
                if (ranNumber >= 0.5f)
                {
                    turnRight = true;
                }
                else
                {
                    turnRight = false;
                }
                turnTime = ratTurnTime;
            }

            if (turnRight == true)
            {
                transform.Rotate(0, 0, 2.0f);
            }
            else
            {
                transform.Rotate(0, 0, -2.0f);
            }
        }
        else if (baitedTraps.Length >= 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, baitedTraps[0].transform.position, 0.45f);
            //transform.rotation = Quaternion.SetLookRotation(Vector3.MoveTowards(transform.position, baitedTraps[0].transform.position, 0.45f));
        }


        if (trappedRat == true)
        {
            this.transform.SetParent(trap.transform);
            transform.position = this.transform.parent.position;
            transform.rotation = this.transform.parent.rotation;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "baitedtrap")
        {
            trappedRat = true;
            trap = col.gameObject;
            Destroy(this.GetComponent<Rigidbody>());
        }
    }
}