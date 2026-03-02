using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerUI : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] private Image[] hearts; // перетащишь сюда 3 сердечка
    
    private TextMeshPro score;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        if (gameManager == null)
        {
            Debug.Log($"{nameof(gameManager)} отсуствует");
            return;
        }
    }

}
