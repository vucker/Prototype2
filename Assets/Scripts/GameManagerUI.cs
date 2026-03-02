using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerUI : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] private Image[] hearts; // перетащишь сюда 3 сердечка
    [SerializeField] private TextMeshProUGUI score;


    private string scorePref = "Счёт: ";
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        if (gameManager == null)
        {
            Debug.Log($"{nameof(gameManager)} отсуствует");
            return;
        }
    }
    private void Start()
    {
        score.color = Color.white;
    }
    private void Update()
    {
        RefreshScore();
        RefreshHearts();
    }
    void RefreshScore()
    {
        score.text = $"{scorePref}{gameManager.score}";
    }
    void RefreshHearts()
    {
        for (int i = 0; i < hearts.Length; i++) 
            {
            if (hearts[i] != null)
            {
                hearts[i].enabled = i < gameManager.currentHP;
            }
        }
    }
}
