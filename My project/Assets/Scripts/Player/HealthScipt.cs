using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScipt : MonoBehaviour
{
    
    public int currentHealth;
    public int maxHealth = 10;
    void Start()
    {
        currentHealth = maxHealth;

    }

    // Update is called once per frame
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
