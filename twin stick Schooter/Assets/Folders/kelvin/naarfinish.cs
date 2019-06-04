using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class naarfinish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Timetext.finnish = true;
        SceneManager.LoadScene("finish");
    }
}
