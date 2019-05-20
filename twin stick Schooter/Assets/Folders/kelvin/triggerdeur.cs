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
        animator.SetBool("active", true);
         
            //animator.SetTrigger("opendoor2");
    }
    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("active", false);
    }
    void pauseAnimationEvent()
    {
       
    }
}