using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Image image;
    public GameObject button;
    public GameObject canvas;
    private bool deze;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
        button.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Triggerdeur.gotkeycard == true)
        {
            deze = true;
        }
        //image.enabled = false;

        if (Input.GetKeyUp(KeyCode.E))
        {
            canvas.SetActive(true);
            if (Triggerdeur.gotkeycard == true)
            {
                image.enabled = true;
                button.SetActive(true);
            }
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            canvas.SetActive(false);
        }
        if (deze)
        {

        }
    }
}
