using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartScreenUI : MonoBehaviour
{
    [Header("Панель")]
    [SerializeField] private GameObject gameOverPanel;

    [Header("Тексты")]
    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private TextMeshProUGUI finalScoreText;
}
