using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody Rigid;
    public float MouseSensitivity;
    public float MoveSpeed;
   // public float JumpForce;
    public GameObject playerCamera;

    Quaternion _initialOrientation;
    Vector2 _currentAngles;

    CursorLockMode _previousLockState;
    bool _wasCursorVisible;

    void Start()
    { 

    }

    void OnEnable()
    {
        _initialOrientation = transform.localRotation;

        _previousLockState = Cursor.lockState;
        _wasCursorVisible = Cursor.visible;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    void Update()
    {
        Rigid.MoveRotation(Rigid.rotation * Quaternion.Euler(0, Input.GetAxis("Mouse X") * MouseSensitivity, 0));
        //Debug.Log(this.playerCamera.transform.rotation.x);

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

    void OnDisable()
    {

        Cursor.visible = _wasCursorVisible;
        Cursor.lockState = _previousLockState;
        transform.localRotation = _initialOrientation;
    }



}

