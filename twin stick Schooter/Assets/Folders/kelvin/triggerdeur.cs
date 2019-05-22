using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerdeur : MonoBehaviour
{
    private Animator animator;
    public int deur;
    public static bool gotkeycard = false;
    public static bool gotrodekeycard = false;
    public static bool gotrozekeycard = false;
    public static bool gotblouwekeycard = false;
    public bool openbool;
    private void Start()
    {
        animator = GetComponent<Animator>();
  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (deur == 1 && gotrodekeycard)
        {
            animator.SetBool("active", true);
        }
        else if (deur == 2 && gotrozekeycard)
        {
            animator.SetBool("active", true);
        }
        if (deur == 3 && gotblouwekeycard)
        {
            animator.SetBool("active", true);
        }
        if (deur == 0)
        {
            animator.SetBool("active", true);
        }
       

    }
    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("active", false);
    }
}