using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Amotext : MonoBehaviour
{
    public Text text;
    private int currentamo;
    private int maxamo;

    public Image amobar;
    private float omrekenen;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        omrekenen = currentamo;
        omrekenen = omrekenen / 5;
        amobar.fillAmount = omrekenen;
        text.text = "amo:" + currentamo + "/" + maxamo;
        currentamo = Guncontroller.currentAmmo;
        maxamo = Guncontroller.maxamo;
    }
}
