using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTest : MonoBehaviour
{

    private void OnTriggerEnter(Collider col)
    {
        HealthBarScripts.health -= 10f;
    }
}
