using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    [SerializeField] private Animal animal;
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
            gameManager.AddHP();
            Destroy(gameObject);
            if (gameManager.IsDie())
            {
                Debug.Log("Game Over");
                Destroy(other.gameObject);
            }

        }
        else if (other.CompareTag("Projectile"))
        {
            animal.AddSatiety();
            Destroy(other.gameObject);

            if (animal.IsFed())
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
                gameManager.AddScore(animal.nameAnimal, animal.feedScore);
                gameManager.TotalScore();

            }
        }
    }
}
