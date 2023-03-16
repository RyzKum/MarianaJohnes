using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
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
            playerSr.enabled = false;
            playerMovement.enabled = false;
        }
    }
}
