using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class testspell : MonoBehaviour
{
    public GameObject projectile;
    public float projectileForce;

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            GameObject spell = Instantiate(projectile, transform.position, Quaternion.identity);
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 myPos = transform.position;
            Vector2 direction = (mousePos - myPos).normalized;
            //spell.transform.rotation = ;
            spell.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;
            Destroy(spell,2);
        }
    }
}
