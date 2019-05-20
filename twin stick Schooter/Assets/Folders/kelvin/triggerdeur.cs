using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerdeur : MonoBehaviour
{
    private Animator animator;
    public static bool gotkeycard = false;
    public bool openbool;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
            animator.SetTrigger("opendoor");
    }
    private void OnTriggerExit(Collider other)
    {
        animator.enabled = true;
    }
    void pauseAnimationEvent()
    {
        animator.enabled = false;
    }
}