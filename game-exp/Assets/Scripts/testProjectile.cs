using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testProjectile : MonoBehaviour
{
    public float minDamage;
    public float maxDamage; 

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name != "Player" & collision.name != "testSpell(Clone)")
        {
            if(collision.GetComponent<enemy_receive_dmg>() != null)
            {
                collision.GetComponent<enemy_receive_dmg>().DealDamage(Random.Range(minDamage, maxDamage));
            }
                        
        Destroy(gameObject); 

        }
    }
}
