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
    void Update()
    {
        health -= amount;
        if(health <= 0)
    }
}
