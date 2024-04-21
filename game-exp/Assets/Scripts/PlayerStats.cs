using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats playerStats;

    public GameObject player;

    public float health;
    public float maxHealth;

    
    void Start()
    {
        health = maxHealth;
    }

    public void DealDamage(float damage)
    {
        health -= damage;
        CheckDeath();
    }

    public void HealCharacter(float heal)
    {
        health += heal;
        CheckOverHeal();
    }

    public void CheckOverHeal()
    {

        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
    public void CheckDeath()
    {
        if (health <= 0)
        {
            Destroy(player);
        }
    }

    
}
