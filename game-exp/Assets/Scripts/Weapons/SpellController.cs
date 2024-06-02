using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellController : WeaponController
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start(); 
    }
    
    protected override void Attack()
    {
        base.Start();
        GameObject spawnedSpell = Instantiate(prefab);
        spawnedSpell.transform.position = transform.position;
        spawnedSpell.GetComponent<SpellProjectile>().DirectionChecker(pm.directionHistory);
    }
}
