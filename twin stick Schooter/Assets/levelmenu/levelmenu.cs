﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmenu : MonoBehaviour
{
    public static int getal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadscene()
    {
        if (getal == 1)
        {
            SceneManager.LoadScene("level1");
        }
        if (getal == 2 )
        {
            SceneManager.LoadScene("level2");
        }
    }
}
