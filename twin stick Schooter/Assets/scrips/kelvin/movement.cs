using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private KeyCode Rechts;
    [SerializeField] private KeyCode links;
    [SerializeField] private KeyCode up;
    [SerializeField] private KeyCode down;

    public float movementspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(Rechts))
        //{
        //    transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementspeed;
        //}
        //if (Input.GetKey(links))
        //{
        //    transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementspeed;
        //}
        //if (Input.GetKey(up))
        //{
        //    transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementspeed;
        //}
        //if (Input.GetKey(down))
        //{
        //    transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementspeed;
        //}
        transform.Translate(movementspeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,movementspeed*Input.GetAxis("Vertical")*Time.deltaTime);
    }
}
