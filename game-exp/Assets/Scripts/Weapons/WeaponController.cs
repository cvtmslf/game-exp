using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WeaponController : MonoBehaviour
{
    [Header("Weapon Stats")]
    public GameObject prefab;
    public float damage;
    public float speed;
    public float cooldownDuration;
    float currentCooldwon;
    public int pierce;

    protected PlayerMovement pm;
    protected virtual void Start()
    {
        pm = FindObjectOfType<PlayerMovement>();
        currentCooldwon = cooldownDuration; //At the start set the current cooldown to be the cooldown duration
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        currentCooldwon -= Time.deltaTime;
        if(currentCooldwon <= 0f)
        {
            Attack();
        }
    }

    protected virtual void Attack()
    {
        currentCooldwon = cooldownDuration;
    }
}
