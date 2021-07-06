using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGrenade : Grenade
{
    private PlayerHealth health;

    private void Start() => FindGameController();

    // Explodes immediately if players touch the grenade
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Physics.IgnoreCollision(collision.transform.GetComponent<Collider>(), GetComponent<Collider>());
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Explosion(0));
        }
    }

    protected override void HandleCollisions()
    {
        base.HandleCollisions();

        foreach(Collider collider in colliders)
        {
            if (collider.CompareTag("Player"))
            {                
                AddKnockback(collider);
            }
        }
    }

    private void AddKnockback(Collider collider)
    {
        Vector3 playerPosition = collider.transform.position;
        Vector3 knockbackDirection = playerPosition - transform.position;
        knockbackDirection.y = 0;

        float distanceToPlayer = Vector3.Distance(transform.position, playerPosition);

        PlayerKnockback player = collider.GetComponent<PlayerKnockback>();

        if (distanceToPlayer > ExplosionRadius / 1.3f)
        {
            health.ReduceHealth(Damage);
            player.Knockback(knockbackDirection.normalized, Force, Length);
        }
        else
        {
            health.ReduceHealth(Damage * 2);
            player.Knockback(knockbackDirection.normalized, Force * 2, Length * 1.75f);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, ExplosionRadius);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, ExplosionRadius / 1.3f);        
    }
    private void FindGameController()
    {
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        health = gameController.GetComponent<PlayerManager>().Health;
    }
}
