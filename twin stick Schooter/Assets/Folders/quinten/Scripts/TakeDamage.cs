using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TakeDamage : MonoBehaviour
{
    public static float health = 1f;
    public static float armor = 1f;
    public static int death;
    private bool naarhealth = false;
    private bool Cheatcode = false;
    public Image healtbar;
    public Image armorbar;
    public GameObject deathscreen;
    public GameObject player;
    private float spawnpointx;
    private float spawnpointy;
    private float spawnpointz;
    void Start()
    {
        health = 1f;
        armor = 1f;
        spawnpointx = 6.812796f;
        spawnpointy = 0.189f;
        spawnpointz = -8.907f;
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
            //Destroy(gameObject);
            SceneManager.LoadScene("deathscene");

            player.transform.position = new Vector3(spawnpointx,spawnpointy,spawnpointz);
            death++;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            health = 10000f;
            armor = 10000f;
            
        }
    }

}
