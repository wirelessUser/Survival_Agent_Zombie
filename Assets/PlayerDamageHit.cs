using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageHit : MonoBehaviour
{
    public PlayerBehaviour playerBehavRef;
    public int damageAmount;
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag=="Player")
        {
           trigger.gameObject.GetComponent<PlayerBehaviour>().TakeDamage(damageAmount);
        }
    }
}
