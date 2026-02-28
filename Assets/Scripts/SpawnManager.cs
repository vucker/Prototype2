using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex = 0;
    void Update()
    {
        Instantiate(animalPrefabs[animalIndex], transform.position, animalPrefabs[animalIndex].transform.rotation);
    }
}
