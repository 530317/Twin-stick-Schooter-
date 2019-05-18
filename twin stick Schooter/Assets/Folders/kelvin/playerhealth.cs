using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhealth : MonoBehaviour
{
    public static float playerhealth;
    public static int armor;
    public static int damage;
    // Start is called before the first frame update
    void Start()
    {
        playerhealth = 100f;
        armor = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerhealth < 0)
        {
            Debug.Log("player died ");
        }
        if (armor > 0)
        {
            playerhealth = playerhealth - damage;
        }
        if (armor > 50)
        {
            armor = armor - damage;
        }
    }

}
