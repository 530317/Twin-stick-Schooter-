using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startmenu : MonoBehaviour
{
    public void level()
    {
        SceneManager.LoadScene("level 1");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
