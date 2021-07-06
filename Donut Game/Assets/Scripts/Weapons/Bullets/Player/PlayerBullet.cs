using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : Bullet
{    
    protected void OnEnable() => bulletRb.AddForce(BulletDirection * BulletSpeed);

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyHealth>().ReduceHealth(Damage);
            gameObject.SetActive(false);
        }
    }

}
