using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellProjectile : ProjectileWeaponBehaviour
{
    SpellController sc;


    protected override void Start()
    {
        base.Start();
        sc = FindObjectOfType<SpellController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * sc.speed * Time.deltaTime;
    }
}
