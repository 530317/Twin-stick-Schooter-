using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickuparmor : MonoBehaviour
{
    public Inventory inventory;
    public GameObject itembutton;


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
                    break;
                }
            }
        }
    }
    public void knop()
    {
        TakeDamage.armor = 1f;
        Destroy(gameObject);
    }
}
