using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodeDeurTrigger : MonoBehaviour
{
    private Animator animator;
    public static bool gotrkeycard = false;
    public bool openbool;
    private void Start()
    {
        animator = GetComponent<Animator>();

    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("active", true);
        //animator.SetTrigger("opendoor2");
    }
    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("active", false);
    }
}
