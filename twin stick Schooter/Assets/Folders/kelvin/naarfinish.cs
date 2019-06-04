using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Naarfinish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Timetext.finnish = true;
        SceneManager.LoadScene("finish");
    }
}
