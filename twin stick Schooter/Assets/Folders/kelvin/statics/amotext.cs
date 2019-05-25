using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Amotext : MonoBehaviour
{
    public Text text;
    private int currentamo;
    private int maxamo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = "amo:" + currentamo + "/" + maxamo;
        currentamo = Guncontroller.currentAmmo;
        maxamo = Guncontroller.maxamo;
    }
}
