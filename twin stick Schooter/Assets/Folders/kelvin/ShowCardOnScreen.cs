using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCardOnScreen : MonoBehaviour
{
    public GameObject keycard1;
    public GameObject keycard2;
    public GameObject keycard3;

    // Start is called before the first frame update
    void Start()
    {
        keycard1.SetActive(false);
        keycard2.SetActive(false);
        keycard3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Triggerdeur.gotrodekeycard == true)
        {
           keycard1.SetActive(true);
        }
        if (Triggerdeur.gotblouwekeycard == true)
        {
            keycard2.SetActive(true);
        }
        if (Triggerdeur.gotrozekeycard == true)
        {
            keycard3.SetActive(true);
        }
       
    }
}
