using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testEnemyShooting : MonoBehaviour
{
    public GameObject projectile;
    public Transform Player;
    public float projectileForce;
    public float cooldown;
    

    void Start()
    {
        StartCoroutine(ShootPlayer());

    }

    IEnumerator ShootPlayer()
    {
        yield return new WaitForSeconds(cooldown);
        if (Player != null ) 
        { 
            GameObject spell = Instantiate(projectile, transform.position, Quaternion.identity);
            Vector2 myPos = transform.position;
            Vector2 targerPos = Player.position;
            Vector2 direction = (targerPos - myPos).normalized;
            spell.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;
            Destroy(spell,2);
            StartCoroutine(ShootPlayer());
        }
    }
}
