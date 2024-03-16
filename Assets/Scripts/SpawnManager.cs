using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] notePrefabs;
    [SerializeField] private Transform[] spawnPoints;

    [SerializeField] private float startDelay = 10f;

    [SerializeField] private float spawnLowerBound = 0.5f;
    [SerializeField] private float spawnHigherBound = 1.5f;


    private void Start()
    {
        StartCoroutine(SpawnRandomNote());
    }

    private IEnumerator SpawnRandomNote()
    {
        yield return new WaitForSeconds(startDelay);

        while(true)
        {
            int noteIndex = Random.Range(0, notePrefabs.Length);
            int spawnIndex = Random.Range(0, spawnPoints.Length);

            Vector3 spawnPos = spawnPoints[spawnIndex].position;

            Instantiate(notePrefabs[noteIndex], spawnPos,
                notePrefabs[noteIndex].transform.rotation);

            float spawnInterval = Random.Range(spawnLowerBound, spawnHigherBound);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
