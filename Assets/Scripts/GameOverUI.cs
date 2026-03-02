using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    [Header("Панель")]
    [SerializeField] private GameObject gameOverPanel;

    [Header("Тексты")]
    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private TextMeshProUGUI finalScoreText;

    [Header("Кнопки")]
    [SerializeField] private Button restartButton;

    [Header("Настройки")]
    [SerializeField] private float fadeInTime = 0.5f;
    [SerializeField] private string gameSceneName = "Game";


}
