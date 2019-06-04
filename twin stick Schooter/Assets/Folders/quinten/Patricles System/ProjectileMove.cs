using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{

    public float speed;
    public float fireRate;
    


    void Start()
    {
        
    }

   
    void Update()
    {
        StartCoroutine(schooting());

    }

    IEnumerator schooting()
    {        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        yield return new WaitForSeconds(2f);
       
    }
}
