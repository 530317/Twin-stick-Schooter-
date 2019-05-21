using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeDamage : MonoBehaviour
{
    private float health = 1f;
    private float armor = 1f;
    private bool naarhealth = false;
    private bool Cheatcode = false;
    public Image healtbar;
    public Image armorbar;


    void Start()
    {
        
    }

     void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Bullet")
        {
            armor -= 0.5f;
            if (naarhealth)
            {
                health -= 0.3f;
            }
        }

        
    }


    void Update()
    {
        healtbar.fillAmount = health;
        armorbar.fillAmount = armor;
        if (armor == 0f)
        {
            naarhealth = true;
        }
        else if (health < 0f)
        {
            Destroy(gameObject);
                
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            health = 10000f;
            armor = 10000f;
            
        }
    }
}
