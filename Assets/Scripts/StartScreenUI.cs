using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartScreenUI : MonoBehaviour
{
    [Header("Панель")]
    [SerializeField] private GameObject startScreenPanel;

    private static bool gameStarted = false;

    private void StartScreenShow()
    {
        startScreenPanel.SetActive(true);
    }
    private void Start()
    {
        gameStarted = false;
        if (!gameStarted)
        {
            Time.timeScale = 0f;
            StartScreenShow();
        }
    }
    private void Update()
    {
        if (!gameStarted && Input.GetKey(KeyCode.Space))
        {
            Time.timeScale = 1f;
            startScreenPanel.SetActive(false);
            StartGame();

        }
            
    }
    private void StartGame()
    {
        gameStarted = true;
    }
}
