using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySword : BasicSword
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().ReduceHealth(data.damage);
            AddKnockback(other);
        }
    }
    private void AddKnockback(Collider collider)
    {
        Vector3 playerPosition = collider.transform.position;
        Vector3 knockbackDirection = playerPosition - transform.position;
        knockbackDirection.y = 0;

        PlayerKnockback player = collider.GetComponent<PlayerKnockback>();
        player.Knockback(knockbackDirection.normalized, 2, 0.5f);        
    }
}
