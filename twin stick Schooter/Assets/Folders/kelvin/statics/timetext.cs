using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timetext : MonoBehaviour
{
    public Text text;
    private float starttimer;
    private bool finnish = false;
    // Start is called before the first frame update
    void Start()
    {
        starttimer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (finnish)
                 return;
        float t = Time.time - starttimer;

        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("0");

        text.text = "timer: " + min + ":" + sec;
    }
    public void finnished()
    {
        finnish = true;
        text.color = Color.red;
    }
}
