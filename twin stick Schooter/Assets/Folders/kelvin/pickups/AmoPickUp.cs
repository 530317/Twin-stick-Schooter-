using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmoPickUp : MonoBehaviour
{
    public Inventory inventory;
    public GameObject itembutton;
    private int I;
    private void OnTriggerEnter(Collider other)
    {
       
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
    public void knop()
    {
      Guncontroller.maxamo = 30;
        inventory.isFull[I] = false;
        Destroy(itembutton);
    }
}
