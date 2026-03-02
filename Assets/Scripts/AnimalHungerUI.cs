using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class AnimalHungerUI : MonoBehaviour
{
    [Header("Цвета шкалы сытости")]
    [SerializeField] private Color colorBG = Color.black;
    [SerializeField] private Color colorFill = Color.green;

    private Animal animal;
    private Image barBG;
    private Image barFill;
    void Awake()
    {
        animal = GetComponentInParent<Animal>();
        if (animal == null)
        {
            Debug.Log($"{nameof(animal)} отсуствует");
            return;
        }
        barBG = transform.parent.GetComponent<Image>();
        if (barBG == null)
        {
            Debug.Log($"{nameof(barBG)} отсуствует");
            return;
        }
        barFill = GetComponent<Image>();
        if (barFill == null)
        {
            Debug.Log($"{nameof(barFill)} отсуствует");
            return;
        }
        
    }
    private void Start()
    {
        barBG.color = colorBG;
        barFill.color = colorFill;
        barFill.fillAmount = (float)animal.currentSatiety / animal.maxSatiety;
    }

    // Update is called once per frame
    void Update()
    {
        barFill.fillAmount = (float)animal.currentSatiety / animal.maxSatiety;
    }
}
