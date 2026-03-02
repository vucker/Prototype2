using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
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

    bool isRestart;

    private GameManager gameManager;
    private void Awake()
    {
        gameManager = GetComponent<GameManager>();
    }
    private void Start()
    {
        GameOverHide();
        restartButton.onClick.AddListener(Restart);
    }
    private void Update()
    {
        if (gameManager.IsDie() && !isRestart)
            GameOverShow();
    }
    private void GameOverShow()
    {
        Time.timeScale = 0f;
        finalScoreText.text = gameManager.TotalScore();
        gameOverPanel.SetActive(true);
    }
    private void GameOverHide()
    {
        gameOverPanel.SetActive(false);
    }
    public void Restart()
    {
        isRestart = true;
        Time.timeScale = 1f;
        SceneManager.LoadScene($"{gameSceneName}");
    }
}
