﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupkeycard : MonoBehaviour
{
    public int getal;
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
        Debug.Log("trigger");
        if (other.name == "player1")
        {
                    if (getal == 1)
                    {
                        Triggerdeur.gotrodekeycard = true;
                        Destroy(gameObject);
                    }
                    if (getal == 2)
                    {
                        Triggerdeur.gotrozekeycard = true;
                        Destroy(gameObject);
                    }
                    if (getal == 3)
                    {
                        Triggerdeur.gotblouwekeycard = true;
                        Destroy(gameObject);
                    }
        }
    }

}
