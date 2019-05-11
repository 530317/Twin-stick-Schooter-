using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guncontroller : MonoBehaviour
{
    public bool isfiring;

    public bulletcontroller bullet;
    public float bulletSpeed;

    public float timeBtweenShots;
    private float shotCounter;

    public int maxamo = 30;
    public int currentAmmo = -1;
    public float reloadtime = 1f;
    private bool isreloading = false;

    public Text text;
    public Transform firepoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
                StartCoroutine(fire());
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
        text.text = "amo:" + currentAmmo + "/30";
    }
    IEnumerator Reload()
    {
        if (Input.GetKey(KeyCode.R))
        {
            isreloading = true;


            Debug.Log("reloding");
            yield return new WaitForSeconds(reloadtime);
            currentAmmo = maxamo;
            isreloading = false;
        }
    }
    IEnumerator fire()
    {
        currentAmmo--;
        shotCounter = timeBtweenShots;
        bulletcontroller newbullet = Instantiate(bullet, firepoint.position, firepoint.rotation) as bulletcontroller;
        newbullet.speed = bulletSpeed;
        yield return new WaitForSeconds(3f);
    }
}
