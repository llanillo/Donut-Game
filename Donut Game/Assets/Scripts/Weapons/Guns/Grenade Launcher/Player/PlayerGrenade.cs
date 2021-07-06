using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrenade : Grenade
{
    private EnemyHealth enemyHealth;

    protected override void OnEnable()
    {
        ShootDirection *= 15;
        base.OnEnable();
    }

    // Explodes immediately if players touch the grenade
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            StartCoroutine(Explosion(0));
        }
    }

    protected override void HandleCollisions()
    {
        base.HandleCollisions();

        foreach(Collider collider in colliders)
        {
            if (collider.CompareTag("Enemy"))
            {
                enemyHealth = collider.GetComponent<EnemyHealth>();
                enemyHealth.ReduceHealth(Damage);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, ExplosionRadius); 
    }
}
