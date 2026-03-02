using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public string nameAnimal = string.Empty;
    public int maxSatiety = 0;
    public int currentSatiety = 0;

    private void Start()
    {
        currentSatiety = 0;
    }
    public void AddSatiety(int satietyAmmount = 1)
    {
        currentSatiety += satietyAmmount;
    }
    public bool IsFed() => currentSatiety >= maxSatiety;
}
