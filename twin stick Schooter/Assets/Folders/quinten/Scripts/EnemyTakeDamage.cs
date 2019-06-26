﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.AI;
public class EnemyTakeDamage : MonoBehaviour
{
    public int enemy;
    public static float health1;
    public static float health2;
    public static float health3;
    public static float health4;
    public Image healtbar1;
    public Image healtbar2;
    public Image healtbar3;
    public Image healtbar4;
  
    
    void Start()
    {
        health1 = 1f;
        health2 = 1f;
        health3 = 1f;
        health4 = 1f;
    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "PlayerBullet" && enemy == 1)
        {
            health1 -= 0.3f;
            
            if (health1 < 0f)
            {
                Destroy(gameObject);
                Score.score++;
                
            }
        }
        else if (hit.gameObject.tag == "PlayerBullet" && enemy == 2)
        {
            health2 -= 0.3f;

            if (health2 < 0f)
            {
                Destroy(gameObject);
                Score.score++;
            }
        }
        else if (hit.gameObject.tag == "PlayerBullet" && enemy == 3)
        {
            health3 -= 0.3f;

            if (health3 < 0f)
            {
                Destroy(gameObject);
                Score.score++;
            }
        }
        else if (hit.gameObject.tag == "PlayerBullet" && enemy == 4)
        {
            health4 -= 0.3f;

            if (health4 < 0f)
            {
                Destroy(gameObject);
                Score.score++;
            }
        }
    }




    void Update()
    {
        healtbar1.fillAmount = health1;   
        healtbar2.fillAmount = health2;
        healtbar3.fillAmount = health3;
        healtbar4.fillAmount = health4;
             
    }
}
