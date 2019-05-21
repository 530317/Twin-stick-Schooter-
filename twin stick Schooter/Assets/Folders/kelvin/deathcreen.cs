using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class deathcreen : MonoBehaviour
{
    public Text deaths;
    public Text deathdoor;
    private int deathcount;
    private int deathdoorname;
    // Start is called before the first frame update
    void Start()
    {
        
        //deathdoorname = 
    }

    // Update is called once per frame
    void Update()
    {
        deathcount = TakeDamage.death;
        deaths.text = "deaths:" + deathcount;
        deathdoor.text = "death door:" + deathdoorname;  
    }
    public void BackToStart()
    {
        SceneManager.LoadScene("start");
    }
}
