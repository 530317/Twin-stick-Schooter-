﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickuparmor : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger2");
        if (other.name == "Player1")
        {
            //Destroy(gameObject);
        }

    }
}