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
    [SerializeField] private string gameSceneName = "Prototype 2";

    bool isRestart;

    private string gameWin =  "Это невероятно!";
    private string gameLose = "Животные вас съели!";

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
        {

            gameOverText.text = gameLose;
            gameOverText.color = Color.red;
            GameOverShow();
        }
        else if (gameManager.IsWin() && !isRestart)
        {

            gameOverText.text = gameWin;
            gameOverText.color = Color.yellow;
            GameOverShow();
        }
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
