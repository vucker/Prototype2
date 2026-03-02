using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private GameManager gameManager;

    [Header("Настройки спавна")]
    public GameObject[] animalPrefabs;
    public float startDelay = 2f;
    public float interval = 1.5f;
    [Header("Настройки поворота")]
    private Quaternion spawnRotUp = Quaternion.Euler(0, 180, 0); //сверху-вниз
    private Quaternion spawnRotDown = Quaternion.Euler(0, 0, 0); //снизу-вверх
    private Quaternion spawnRotRight = Quaternion.Euler(0, -90, 0); //справа-налево
    private Quaternion spawnRotLeft = Quaternion.Euler(0, 90, 0); //слева-направо

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        
        if (gameManager == null)
        {
            Debug.Log($"{nameof(gameManager)} отсуствует");
            return;
        }
        //Фунция для запуска функции интервалами
        InvokeRepeating("SpawnRandomAnimal", startDelay, interval);
    }
    void SpawnRandomAnimal()
    {
        if (gameManager == null) return;

        float spawnPosX = 0f,
            spawnPosZ = 0f;
        Quaternion spawnRot = Quaternion.Euler(0,0,0);

        if (IsSpawnUpDown())
        {
            spawnPosX = Random.Range(gameManager.areaX.x, gameManager.areaX.y);
            spawnPosZ = IsSpawnUpRigth() ? gameManager.areaZ.y : gameManager.areaZ.x;
            spawnRot = spawnPosZ == gameManager.areaZ.y ? spawnRotUp : spawnRotDown;
        }
        else
        {
            spawnPosZ = Random.Range(gameManager.areaZ.x, gameManager.areaZ.y);
            spawnPosX = IsSpawnUpRigth() ? gameManager.areaX.y : gameManager.areaX.x;
            spawnRot = spawnPosX== gameManager.areaX.y ? spawnRotRight : spawnRotLeft;

        }
        //Позиция для спавна
        Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnPosZ);
        //Рандомный индекс для животных
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //Призыв животного
        Instantiate(animalPrefabs[animalIndex], spawnPos, spawnRot);
    }
    bool IsSpawnUpDown() => Random.value < 0.5f;
    bool IsSpawnUpRigth() => Random.value < 0.5f;
}
