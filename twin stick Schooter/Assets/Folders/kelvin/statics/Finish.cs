using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public Text playerscore;
    public Text Time;
    public Text deaths;

    private int deathcount;
    private int score;
    private string time;

    // Start is called before the first frame update
    void Start()
    {
        deathcount = TakeDamage.death + 1;
        score = Score.score;
        time = Timetext.time;
    }

    // Update is called once per frame
    void Update()
    {
        deaths.text = "aantal keer gespeel:" + deathcount;
        playerscore.text = "playerscore" + score ;
        Time.text = time;
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
    }
    public void Resume()
    {
        SceneManager.LoadScene("sene nieke");
    }
}
