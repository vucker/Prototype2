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
        else if (transform.position.x < SetGameArea().x ||
            transform.position.x > SetGameArea().x ||
            transform.position.z < SetGameArea().y ||
            transform.position.z > SetGameArea().y)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
    Vector2 SetGameArea()
    {
        float clampX = Mathf.Clamp(transform.position.x, gameManager.areaX.x, gameManager.areaX.y);
        float clampZ = Mathf.Clamp(transform.position.z, gameManager.areaZ.x, gameManager.areaZ.y);
        Vector2 gameArea = new Vector3(clampX, clampZ);
        return gameArea;
    }
}
