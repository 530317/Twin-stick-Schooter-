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
        Debug.Log("trigger");
        if (other.name == "Player1" && gotkeycard)
        {
            animator.SetBool("open", true);
            gotkeycard = false;
        }

            
    }
}