using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerplate : MonoBehaviour
{
    [SerializeField] GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        door.transform.position += new Vector3(0, 3, 0);
    }
}
