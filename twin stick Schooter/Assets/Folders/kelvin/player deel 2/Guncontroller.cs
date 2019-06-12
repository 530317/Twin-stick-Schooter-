using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guncontroller : MonoBehaviour
{
    Muzzleflash muzzelflash;
    public bool isfiring;
    public Bulletcontroller bullet;
    public float bulletSpeed;

    public float timeBtweenShots;
    private float shotCounter;

    public static int maxamo = 0;
    public static int currentAmmo = 0;
    public float reloadtime = 1f;
    private bool isreloading = false;

    public Transform firepoint;

    // Start is called before the first frame update
    void Start()
    {
        maxamo = 0;
        currentAmmo = 0; 
       muzzelflash = GetComponent<Muzzleflash>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            maxamo = 10000;
            currentAmmo = maxamo;
        }
        if (isreloading)
        {
            return;
        }
        if (currentAmmo <= 0)
        {
               StartCoroutine(Reload());
               return;
        }
        if (isfiring)
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
            {
                muzzelflash.Activate();
                StartCoroutine(Fire());
                //currentAmmo--;
                //shotCounter = timeBtweenShots;
                //bulletcontroller newbullet = Instantiate(bullet, firepoint.position, firepoint.rotation) as bulletcontroller;
                //newbullet.speed = bulletSpeed;
            }
        }
        else
        {
            shotCounter = 0;
        }
       
    }
    IEnumerator Fire()
    {
        currentAmmo--;
        shotCounter = timeBtweenShots;
        Bulletcontroller newbullet = Instantiate(bullet, firepoint.position, firepoint.rotation) as Bulletcontroller;
        newbullet.speed = bulletSpeed;
        yield return new WaitForSeconds(3f);
        
    }
    IEnumerator Reload()
    {
        if (maxamo != 0)
        {
            if (Input.GetKey(KeyCode.R))
            {
                isreloading = true;
                Debug.Log("reloading");
                yield return new WaitForSeconds(reloadtime);
                currentAmmo = 5;
                maxamo = maxamo - currentAmmo;
                isreloading = false;
            }
        }
    }
   
}
