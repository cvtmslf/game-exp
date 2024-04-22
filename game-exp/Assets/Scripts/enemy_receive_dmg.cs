using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class enemy_receive_dmg : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public GameObject healthBar;
    public Slider healthBarSlider;

    public GameObject lootDrop;
    void Start()
    {
        health = maxHealth;
    }

    public void DealDamage(float damage)
    {
        healthBar.SetActive(true);
        health -= damage;
        CheckDeath();
        healthBarSlider.value = CalculateHealthPercentage();
    }

    public void CheckOverHeal()
    {

        if (health > maxHealth) 
        {
            health = maxHealth;
        }
        healthBarSlider.value = CalculateHealthPercentage();
    }
    public void CheckDeath() 
    { 
        if (health <= 0) 
        { 
            Destroy(gameObject);
            Instantiate(lootDrop, transform.position, Quaternion.identity); 
        } 
    }

    private float CalculateHealthPercentage()
    {
        return (health / maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
