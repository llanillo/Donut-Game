using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : Bullet
{
    private PlayerHealth health;

    private void Start() => FindGameController();

    protected void OnEnable() => bulletRb.AddForce(BulletDirection * BulletSpeed);

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        if (other.CompareTag("Player")) 
        {
            health.ReduceHealth(Damage);
            gameObject.SetActive(false);
        }          
    }

    private void FindGameController()
    {
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        health = gameController.GetComponent<PlayerManager>().Health;
    }
}
