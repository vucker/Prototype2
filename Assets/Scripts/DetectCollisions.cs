using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        if  ( gameManager == null)
        {
            Debug.Log($"{nameof(gameManager)} отсуствует");
            return;
        }
    }
    //Обнаружение столкновения триггера
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!gameManager.IsDie())
            {
                gameManager.AddHP();
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Game Over");
                Destroy(other.gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            gameManager.AddScore();
        }
    }
}
