using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class enemy_receive_dmg : MonoBehaviour
{
    public float health;
    public float maxHealth;
    void Start()
    {
        health = maxHealth;
    }

    public void DealDamage(float damage)
    { health -= damage;
        CheckDeath();
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
            Destroy(gameObject);                         
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
