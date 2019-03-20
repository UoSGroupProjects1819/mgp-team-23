using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody Rigid;
    public float MoveSpeed;

    Quaternion _initialOrientation;
    Vector2 _currentAngles;

    CursorLockMode _previousLockState;
    bool _wasCursorVisible;



    public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    readonly float sensitivityX = 1F;
    readonly float sensitivityY = 1F;

    readonly float minimumX = -360F;
    readonly float maximumX = 360F;

    readonly float minimumY = -60F;
    readonly float maximumY = 60F;

    float rotationY = 0F;

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
        if (axes == RotationAxes.MouseXAndY)
        {
            float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;

            rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
        }
        else if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
        }
        else
        {
            rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

            transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
        }

        Rigid.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") * MoveSpeed) + (transform.right * Input.GetAxis("Horizontal") * MoveSpeed));


    }

    void OnDisable()
    {

        Cursor.visible = _wasCursorVisible;
        Cursor.lockState = _previousLockState;
        transform.localRotation = _initialOrientation;
    }



}

