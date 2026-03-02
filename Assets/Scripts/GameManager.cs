using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    [Header("Настройки игровой области")]
    public Vector2 areaX = new Vector2(-23f, 23f);
    public Vector2 areaZ = new Vector2(-3f, 23f);
    public Color gizmosColor = Color.green;
    [Header("Настройки счётчиков")]
    private int maxHP = 3;
    public int currentHP = 0;
    public int score = 0;
    public int scoreMax = 9999;


    private GameOverUI gameOverUI;

    private void Awake()
    {
        gameOverUI = GetComponent<GameOverUI>();
    }
    private void Start()
    {
        currentHP = maxHP;
        score = 0;
        Debug.Log($"Текущий запас здоровья: {currentHP}");
        Debug.Log($"Текущий счёт: {score}");
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = gizmosColor;
        Vector3 centerVector = new Vector3(
            (areaX.y + areaX.x) / 2,
            0,
            (areaZ.y + areaZ.x) / 2);
        Vector3 sizeVector = new Vector3(
            areaX.y - areaX.x,
            0,
            areaZ.y - areaZ.x);
        Gizmos.DrawWireCube(centerVector, sizeVector);
    }
    public void AddHP(int addAmount = -1)
    {
        currentHP += addAmount;
        Debug.Log($"Текущий запас здоровья: {currentHP}");
    }
    public void AddScore(string name, int addAmount = 1)
    {
        score += addAmount;
        Debug.Log($"Вы убили: {name}! Получите счёт: {addAmount}!");
    }
    private int CheckTotalScore() => score = Mathf.Clamp( score, 0, scoreMax);
    public string TotalScore() => $"Текущий счёт: {CheckTotalScore()}!";
    public bool IsDie() => currentHP <= 0;
    public bool IsWin() => score >= 9999;

}
