using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentPickup : MonoBehaviour
{
    public enum PickupQuanity { COIN, GEM };
    public PickupQuanity currentObject;
    public int pickupQuantity;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (currentObject == PickupQuanity.COIN)
        {
            PlayerStats.playerStats.coins += pickupQuantity;
        }
        else if (currentObject == PickupQuanity.GEM)
        {
            PlayerStats.playerStats.gems += pickupQuantity;
        }
        Destroy(gameObject);

    }
}
