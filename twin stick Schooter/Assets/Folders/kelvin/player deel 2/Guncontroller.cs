using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guncontroller : MonoBehaviour
{
    public bool isfiring;

    public bulletcontroller bullet;
    public float bulletSpeed;

    public float timeBtweenShots;
    private float shotCounter;

    public Transform firepoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isfiring)
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
            {
                shotCounter = timeBtweenShots;
                bulletcontroller newbullet = Instantiate(bullet, firepoint.position, firepoint.rotation) as bulletcontroller;
                newbullet.speed = bulletSpeed;
            }
        }
        else
        {
            shotCounter = 0;
        }
    }
}
