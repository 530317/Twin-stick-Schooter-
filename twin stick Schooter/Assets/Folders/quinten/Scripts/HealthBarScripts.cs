using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScripts : MonoBehaviour
{

    Image healthBar;
    float maxHealth;
    public static float health;

   
    void Start()
    {
        maxHealth = Playerhealth.playerhealth; 
        healthBar = GetComponent<Image>();
        health = maxHealth;
    }

    
    void Update()
    {
        healthBar.fillAmount = health / maxHealth;
    }
}
