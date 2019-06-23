using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startmenu : MonoBehaviour
{
    private void Start()
    {
        TakeDamage.death = 0;
    }
    public void Level()
    {
        SceneManager.LoadScene("sene nieke");
    }
    public void Options()
    {
        SceneManager.LoadScene("settings");
    }
    public void Levels()
    {
        SceneManager.LoadScene("levelmenu");
    }
    public void Credits()
    {
        SceneManager.LoadScene("credits");
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void Back()
    {
        SceneManager.LoadScene("start");
    }
}
