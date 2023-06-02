using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public HealthScipt playerHealth;
    public Image fillImage;
    private Slider slider;
    void Awake()
    {
        slider = GetComponent<Slider>();
        slider.maxValue = playerHealth.maxHealth;
    }

    // Update is called once per frame
    void Update() 
    {
        float fillvalue = playerHealth.currentHealth;
        slider.value = fillvalue;
    }
}
