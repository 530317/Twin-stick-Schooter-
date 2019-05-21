using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeDamage : MonoBehaviour
{
    public float health;
    public float armor;
    public Image healtbar;
    public Image armorbar;


    void Start()
    {
        
    }

    
    void Update()
    {
        healtbar.fillAmount = health;
        armorbar.fillAmount = armor;
    }
}
