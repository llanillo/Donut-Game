using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeLauncher : Gun
{
    public override void Attack(Vector3 attackDirection)
    {
        base.Attack(attackDirection);
    }

    protected override void CreateBullet()
    {
        base.CreateBullet();

        Grenade grenadeScript = bullet.GetComponent<Grenade>();
        grenadeScript.ShootDirection = shootDirection;
        grenadeScript.Damage = data.damage;
        grenadeScript.DetonateTime = data.detonateTime;
        grenadeScript.ExplosionRadius = data.explosionRadius;
        grenadeScript.Force = data.force;
        grenadeScript.Length = data.length;
        grenadeScript.Height = data.throwHeight;

        bullet.SetActive(true);
    }
}
