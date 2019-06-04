using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public Text deathstext;
    public Text timertext;
    public Text Scoretext;

    private int deathcount;
    private string time;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        deathcount = TakeDamage.death + 1;
        time = Timetext.time;
        score = Score.score;
    }

    // Update is called once per frame
    void Update()
    {
        deathstext.text = "aantal keer gespeeld:" + deathcount;
        timertext.text = time;
        Scoretext.text = "score" + score;
    }
    public void BackToStart()
    {
        SceneManager.LoadScene("start");
        deathcount = 0;
        Score.score = 0;
        Guncontroller.maxamo = 30;
        Guncontroller.currentAmmo = 0;
        Triggerdeur.gotblouwekeycard = false;
        Triggerdeur.gotrodekeycard = false;
        Triggerdeur.gotrozekeycard = false;

        Timetext.starttimer = 0;
    }
    public void Resume()
    {
        SceneManager.LoadScene("sene nieke");
    }
}
