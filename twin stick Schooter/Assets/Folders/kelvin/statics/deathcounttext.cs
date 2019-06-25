using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathcounttext : MonoBehaviour
{
    public Text deathdoor;
    private int deathcount;
    // Start is called before the first frame update
    void Start()
    { 
        deathcount = TakeDamage.death;
    }

    // Update is called once per frame
    void Update()
    {
        deathdoor.text = "" + deathcount;
    }
}
