using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnPosX = 20;
    public float spawnPosZ = 5;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0f, spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
