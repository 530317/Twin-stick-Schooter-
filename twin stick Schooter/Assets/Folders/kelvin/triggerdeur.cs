﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerdeur : MonoBehaviour
{
    private Animator animator;
    public static bool gotkeycard = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
        //if (Input.GetKey(KeyCode.E))
        //{
            if (other.name == "Player1" && gotkeycard)
            {
                animator.SetBool("open", true);
            }
        //}

    }
}