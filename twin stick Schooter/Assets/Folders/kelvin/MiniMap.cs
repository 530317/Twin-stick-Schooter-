using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    public Transform player;
    private void LateUpdate()
    {
        Vector3 NewPosition = player.position;
        NewPosition.y = transform.position.y;
        transform.position = NewPosition;
    }
}
