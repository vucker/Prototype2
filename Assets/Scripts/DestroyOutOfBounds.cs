using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        // Находим GameManager в сцене автоматически
        gameManager = FindObjectOfType<GameManager>();

        if (gameManager == null)
        {
            Debug.Log($"{nameof(gameManager)} отсуствует");
            return;
        }
    }

    void Update()
    {
        //условие для уничтожения снарядов
        if (transform.position.z > gameManager.areaZ.y)
        {
            Destroy(gameObject);
        }
        //условие для уничтожения животных и поражения
        else if (transform.position.z < gameManager.areaZ.x)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
