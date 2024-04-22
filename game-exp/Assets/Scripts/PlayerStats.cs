using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats playerStats;

    public GameObject player;
    public Text healthText;
    public Slider healthSlider;

    public float health;
    public float maxHealth;

    public int coins;
    public int gems;


    private void Awake()
    {
        if (playerStats != null)
        {
            Destroy(playerStats);
        }
        else
        {
            playerStats = this;
        }
        DontDestroyOnLoad(this);
    }


    void Start()
    {
        health = maxHealth;
        SetHealUI();
    }

    public void DealDamage(float damage)
    {
        health -= damage;
        CheckDeath();
        SetHealUI();
    }

    public void HealCharacter(float heal)
    {
        health += heal;
        CheckOverHeal();
        SetHealUI();
    }

    private void SetHealUI()
    {
        healthSlider.value = CalculateHealthPercentage();
        healthText.text = Mathf.Ceil(health).ToString() + " / " + Mathf.Ceil(maxHealth).ToString();
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
            health = 0;
            Destroy(player);
        }
    }

    public float CalculateHealthPercentage()
    {
        return (health / maxHealth);
    }

}
