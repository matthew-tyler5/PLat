using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScipt : MonoBehaviour
{
    
    public int health;
    public int maxHealth = 10;
    void Start()
    {
        health = maxHealth;

    }

    // Update is called once per frame
    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
