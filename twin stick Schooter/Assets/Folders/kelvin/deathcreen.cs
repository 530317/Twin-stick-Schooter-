﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Deathcreen : MonoBehaviour
{
    public Text deaths;
    public Text deathdoor;
    public Text playerscore;
    public int deathcount;
    private string deathdoorname;
    private int score;

    void Start()
    {
       deathcount = TakeDamage.death;
        score = Score.score;
        deathdoorname = TakeDamage.deathdoor;
    }

    void Update()
    {
        deaths.text = "aantal keer gespeel:" + deathcount;
        deathdoor.text = "death door:" + deathdoorname;
        playerscore.text = "playerscore" + score;
    }
    public void BackToStart()
    {
        SceneManager.LoadScene("start");
        deathcount = 0;
        Score.score = 0;
        Guncontroller.maxamo = 0;
        Guncontroller.currentAmmo = 0;
        Triggerdeur.gotblouwekeycard = false;
        Triggerdeur.gotrodekeycard = false;
        Triggerdeur.gotrozekeycard = false;
        EnemyTakeDamage.health1 = 1f;
        EnemyTakeDamage.health2 = 1f;
        EnemyTakeDamage.health3 = 1f;
        EnemyTakeDamage.health4 = 1f;
        Timetext.starttimer = 0;
    }
    public void Resume()
    {
        SceneManager.LoadScene("sene nieke");
    }
}
