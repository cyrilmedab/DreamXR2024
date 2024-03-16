using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        collider.gameObject.GetComponent<ZoneEffects>().PlayAllZoneEffects();
        Debug.Log("Collision");
    }
}

