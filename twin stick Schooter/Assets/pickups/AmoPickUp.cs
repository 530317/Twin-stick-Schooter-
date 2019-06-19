using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmoPickUp : MonoBehaviour
{
    public Inventory inventory;
    public GameObject itembutton;

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
       
       if (other.name == "player1")
       {
          for (int i = 0; i < inventory.slots.Length; i++)
          {
             if (inventory.isFull[i] == false)
             {
                 Guncontroller.maxamo = 30;
                 inventory.isFull[i] = true;
                 Instantiate(itembutton, inventory.slots[i].transform, false);
                 Destroy(gameObject);
                break;
             }
          }
       }
    }
}
