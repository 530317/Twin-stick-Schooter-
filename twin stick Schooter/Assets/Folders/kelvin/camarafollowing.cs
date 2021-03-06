﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camarafollowing : MonoBehaviour
{
    public Transform target;

    //public float smoothspeed = 0.125f;
    public Vector3 offset;

    private void FixedUpdate()
    {
        Vector3 desiredposition = target.position + offset;
        Vector3 smoothedposition = Vector3.Lerp(transform.position, desiredposition,0f);
        transform.position = smoothedposition;

        transform.LookAt(target);

    }
}
