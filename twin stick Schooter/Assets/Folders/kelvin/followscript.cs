using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followscript : MonoBehaviour
{
    public Transform target;

    public float smoothspeed = 0.125f;
    public Vector3 offset;

    private void FixedUpdate()
    {
        Vector3 desirdposition = target.position + offset;
        Vector3 smoothposition = Vector3.Lerp(transform.position, desirdposition, smoothspeed);
        transform.position = smoothposition;
    }
}
