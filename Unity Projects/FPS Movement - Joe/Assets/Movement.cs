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
        this.playerCamera.transform.Rotate(Input.GetAxis("Mouse Y"), this.transform.rotation.y, this.transform.rotation.z);
        Rigid.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") * MoveSpeed) + (transform.right * Input.GetAxis("Horizontal") * MoveSpeed));
        if (Input.GetKeyDown("space"))
            Rigid.AddForce(transform.up * JumpForce);
    }
}
