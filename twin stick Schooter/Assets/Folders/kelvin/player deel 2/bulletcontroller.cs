using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletcontroller : MonoBehaviour
{
    public float speed;
  
    void Start()
    {
        Destroy(gameObject, 2f);
    }
   
    void Update()
    {
       
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }



}
