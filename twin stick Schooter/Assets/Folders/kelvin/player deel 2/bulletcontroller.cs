using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcontroller : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(schooting());
    }
    IEnumerator schooting()
    {
      
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }

}
