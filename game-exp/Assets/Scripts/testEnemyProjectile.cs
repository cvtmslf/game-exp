using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testEnemyProjectile : MonoBehaviour
{
    public float minDamage;
    public float maxDamage;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Enemy" & collision.name != "testEnemySpell(Clone)")
        {
            if (collision.name == "testSpell(Clone)")
                Destroy(gameObject);
            else
                Destroy(gameObject,5);
        }

    }

}
