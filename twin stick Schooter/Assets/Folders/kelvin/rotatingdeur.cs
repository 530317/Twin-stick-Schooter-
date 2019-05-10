using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingdeur : MonoBehaviour
{
    float smooth = 5.0f;
    float tiltAngle = 60.0f;

    public void rotatedeur()
    {
        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(0, 90, 0);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }

}
