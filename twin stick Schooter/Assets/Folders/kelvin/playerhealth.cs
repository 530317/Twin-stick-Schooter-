using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhealth : MonoBehaviour
{
    public static float playerhealth;
    public static float armor;
    public static float damage;
   
    void Start()
    {
        playerhealth = 1f;
        armor = 1f;
    }


    void Update()
    {
        if (playerhealth < 0f)
        {
            Debug.Log("player died ");
        }
        if (armor > 0f)
        {
            
        }
        if (armor > 1f)
        {
            armor = armor - damage;
        }
    }

}
