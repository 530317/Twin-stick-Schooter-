using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class optionmenu : MonoBehaviour
{
    public static bool gameispauzed = true;
    public GameObject pauzemenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (gameispauzed)
            {
                Resume();
            }
            else
            {
                Pauze();
            }
        }
    }
    public void BackToStart()
    {
        SceneManager.LoadScene("start");
    }
    public void Resume()
    {
        pauzemenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameispauzed = false;
    }
    public void Pauze()
    {
        pauzemenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameispauzed = true;
    }

}
