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
        SceneManager.LoadScene("start");
    }
    public void Levels()
    {
        SceneManager.LoadScene("level 1");
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
