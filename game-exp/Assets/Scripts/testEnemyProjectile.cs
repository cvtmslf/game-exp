using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testEnemyProjectile : MonoBehaviour
{
    public float minDamage;
    public float maxDamage;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Enemy")
        {
            if (collision.tag == "Player")
            {
                PlayerStats.playerStats.DealDamage(Random.Range(minDamage, maxDamage));
                Destroy(gameObject);
            }      
            if (collision.tag == "PlayerSpell")
            {
                Destroy(gameObject);
            }
            else
                Destroy(gameObject,5);
        }

    }

}
