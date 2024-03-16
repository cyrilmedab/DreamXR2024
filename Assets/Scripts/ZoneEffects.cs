using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ZoneEffects : MonoBehaviour
{
    private AudioSource _zoneSound;
    private bool _playerInZone;

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
        if (collider.gameObject.CompareTag("Player"))
        {
            _playerInZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _playerInZone = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Note") && _playerInZone)
        {
            Destroy(other.gameObject);
            PlayAllZoneEffects();
        }
    }
}
