using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public AudioMixer audiomixer;
    public AudioMixer audiomixer2;
    public void SetVolume(float volume)
    {
        audiomixer.SetFloat("volume", volume);
    }
    public void SetVolume2(float volume)
    {
        audiomixer2.SetFloat("volume", volume);
    }
    public void SetQuality(int qualityindex)
    {
        QualitySettings.SetQualityLevel(qualityindex);
    }
    public void Exit()
    {
        SceneManager.LoadScene("start");
    }
}
