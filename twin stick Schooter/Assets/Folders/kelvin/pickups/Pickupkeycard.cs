using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupkeycard : MonoBehaviour
{
    public GameObject onscreen;
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
        if (other.name == "Player1")
        {
            if (getal == 1)
            {
                triggerdeur.gotrodekeycard = true;
            }
            if (getal == 2)
            {
                triggerdeur.gotrozekeycard = true;
            }
           
            onscreen.transform.position = new Vector3(0.97f, 7.9f, -2.07f);
            Destroy(gameObject);
        }
          
    }

}
