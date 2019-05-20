using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScripts : MonoBehaviour
{

    public Image HealthBar;
    float maxHealth;
    public static float health;

   
    void Start()
    {
        maxHealth = Playerhealth.playerhealth; 
        HealthBar = GetComponent<Image>();
        health = maxHealth;
    }

    
    void Update()
    {
        HealthBar.fillAmount = health / maxHealth;
    }
}
