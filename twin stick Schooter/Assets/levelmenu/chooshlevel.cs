using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chooshlevel : MonoBehaviour
{
    public int  getal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onpush()
    {
        if (getal == 1)
        {
            levelmenu.getal = 1;
        }
        if (getal == 2)
        {
            levelmenu.getal = 2;
        }
    }
}
