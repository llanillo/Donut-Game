using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGun : Gun
{
    public override void Attack(Vector3 attackDirection)
    {
        attackDirection.y = 0;
        base.Attack(attackDirection);
    }

    protected override void CreateBullet()
    {
        base.CreateBullet();

        Bullet bulletScript = bullet.GetComponent<Bullet>(); ;
        bulletScript.Damage = data.damage;
        bulletScript.BulletSpeed = data.bulletSpeed;
        bulletScript.BulletDirection = shootDirection;

        bullet.SetActive(true);
    }
}
