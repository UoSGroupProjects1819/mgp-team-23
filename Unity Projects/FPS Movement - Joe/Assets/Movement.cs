using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody Rigid;
    public float MouseSensitivity;
    public float MoveSpeed;
    public float JumpForce;
    public GameObject playerCamera;

    void Update()
    {
        Rigid.MoveRotation(Rigid.rotation * Quaternion.Euler(0, Input.GetAxis("Mouse X") * MouseSensitivity, 0));
        Debug.Log(this.playerCamera.transform.rotation.x);

        if (this.playerCamera.transform.rotation.x <= -0.68f)
        {
            this.playerCamera.transform.Rotate(-0.67f, 0, 0);
        }
        else if (this.playerCamera.transform.rotation.x >= 0.68f)
        {
            this.playerCamera.transform.Rotate(0.67f, 0, 0);
        }
        else
        {
            this.playerCamera.transform.Rotate((Input.GetAxis("Mouse Y") * MouseSensitivity) * -1, 0, 0);
        }

        Rigid.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") * MoveSpeed) + (transform.right * Input.GetAxis("Horizontal") * MoveSpeed));

        //if (Input.GetKeyDown("space"))
        //{
        //    Rigid.AddForce(transform.up * JumpForce);
        //}
    }
}
