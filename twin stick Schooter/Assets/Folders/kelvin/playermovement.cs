using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float movespeed;
    private Rigidbody myRigedbody;

    private Vector3 moveInput;
    private Vector3 moveVelocity;

    private Camera maincamera;
    // Start is called before the first frame update
    void Start()
    {
        myRigedbody = GetComponent<Rigidbody>();
        maincamera = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput * movespeed;

        Ray camaeraRay = maincamera.ScreenPointToRay(Input.mousePosition);
        Plane groundplane = new Plane(Vector3.up, Vector3.zero);
        float raylength;

        if (groundplane.Raycast(camaeraRay,out raylength))
        {
            Vector3 pointToLook = camaeraRay.GetPoint(raylength);
            Debug.DrawLine(camaeraRay.origin, pointToLook, Color.green);
        }
    }
    private void FixedUpdate()
    {
        myRigedbody.velocity = moveVelocity;
    }
}
