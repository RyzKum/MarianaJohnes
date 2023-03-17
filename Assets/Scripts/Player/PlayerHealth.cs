using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerHealth : MonoBehaviour
{

    public static event Action OnPlayerDeath;


    public int maxHealth = 3;
    public int health;



    public SpriteRenderer playerSr;
    public PlayerMovement playerMovement;

    void Start()
    {
        health = maxHealth;
    }


    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            OnPlayerDeath?.Invoke();
        }
    }
}