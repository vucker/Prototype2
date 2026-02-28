using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnPosX = 20;
    public float spawnPosZ = 5;
    public float startDelay = 2f;
    public float interval = 1.5f;

    private void Start()
    {
        //Фунция для запуска функции интервалами
        InvokeRepeating("SpawnRandomAnimal", startDelay, interval);
    }
    void SpawnRandomAnimal()
    {
        //Позиция для спавна
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0f, spawnPosZ);
        //Рандомный индекс для животных
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //Призыв животного
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
