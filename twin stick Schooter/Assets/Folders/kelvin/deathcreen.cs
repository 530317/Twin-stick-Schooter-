using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Deathcreen : MonoBehaviour
{
    public Text deaths;
    public Text deathdoor;
    public Text playerscore;
    private int deathcount;
    private int deathdoorname;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
       deathcount = TakeDamage.death;
        score = Score.score;
    }

    // Update is called once per frame
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
        Triggerdeur.gotblouwekeycard = false;
        Triggerdeur.gotrodekeycard = false;
        Triggerdeur.gotrozekeycard = false;
    }
    public void Resume()
    {
        SceneManager.LoadScene("sene nieke");
    }
}
