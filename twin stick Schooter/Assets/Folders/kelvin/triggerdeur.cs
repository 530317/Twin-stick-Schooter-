using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerdeur : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
            animator.SetBool("open", true);
    }
}