using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ZoneEffects : MonoBehaviour
{
    private AudioSource _zoneSound;

    private void Awake()
    {
        _zoneSound = GetComponent<AudioSource>();
    }

    public void PlayAllZoneEffects()
    {
        PlayAudio();
    }

    private void PlayAudio()
    {
        _zoneSound.Play();
    }

    private void OnTriggerEnter(Collider collider)
    {
        PlayAllZoneEffects();
        Debug.Log("Collision");
    }
}
