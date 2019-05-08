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

    public Guncontroller thegun;

    public bool usecontroller;
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
        // voor mouse
        if (!usecontroller)
        {
            Ray camaeraRay = maincamera.ScreenPointToRay(Input.mousePosition);
            Plane groundplane = new Plane(Vector3.up, Vector3.zero);
            float raylength;

            if (groundplane.Raycast(camaeraRay, out raylength))
            {
                Vector3 pointToLook = camaeraRay.GetPoint(raylength);
                Debug.DrawLine(camaeraRay.origin, pointToLook, Color.green);

                transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
            }
            if (Input.GetMouseButtonDown(0))
            {
                thegun.isfiring = true;
            }
            if (Input.GetMouseButtonUp(0))
            {
                thegun.isfiring = false;
            }
        }
        // rotation controller
        if (usecontroller)
        {
            Vector3 playerDirection = Vector3.right * Input.GetAxisRaw("RHorizontal") + Vector3.forward * -Input.GetAxisRaw("Rvertical");
            if (playerDirection.sqrMagnitude > 0.0f)
            {
                transform.rotation = Quaternion.LookRotation(playerDirection, Vector3.up);
            }
            if (Input.GetKeyDown(KeyCode.Joystick1Button5))
            {
                thegun.isfiring = true;
            }
            if (Input.GetKeyUp(KeyCode.Joystick1Button5))
            {
                thegun.isfiring = false;
            }
        }
    }
    private void FixedUpdate()
    {
        myRigedbody.velocity = moveVelocity;
    }
}
