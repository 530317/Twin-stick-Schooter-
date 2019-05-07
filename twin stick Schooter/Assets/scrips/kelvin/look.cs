using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit _hit;

        if (Physics.Raycast(ray, out _hit))
        {
            transform.LookAt(_hit.point);
        }

        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
    }
}
