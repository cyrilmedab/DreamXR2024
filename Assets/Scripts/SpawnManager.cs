using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] notePrefabs;
    [SerializeField] private Transform[] spawnPoints;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int noteIndex = Random.Range(0, notePrefabs.Length);
            int spawnIndex = Random.Range(0, spawnPoints.Length);

            Vector3 spawnPos = spawnPoints[spawnIndex].position;

            Instantiate(notePrefabs[noteIndex], spawnPos, 
                notePrefabs[noteIndex].transform.rotation);
        }
    }
}
