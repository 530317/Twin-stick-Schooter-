﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickuphealth : MonoBehaviour
{
    public Inventory inventory;
    public GameObject itembutton;
    private int I;
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
        if (other.name == "player1")
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                   if (inventory.isFull[i] == false)
                   {
                       inventory.isFull[i] = true;
                       Instantiate(itembutton, inventory.slots[i].transform, false);
                       Destroy(gameObject);
                       I = i;
                       break;
                   }
            }
        }

    }
    public void healtherbij()
    {
         TakeDamage.health = 1f;
        inventory.isFull[I] = false;
        Destroy(gameObject);
    }
}
