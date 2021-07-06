using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : Weapon
{    
    public Transform bulletSpawn;
    
    protected Vector3 shootDirection;
    protected GameObject bullet;     
    
    private bool isReloading;

    private void Awake() => data.currentAmmo = data.maxAmmo;

    private void OnEnable() => isReloading = false;

    public override void Attack(Vector3 attackDirection)
    {
        shootDirection = attackDirection;
        
        if (data.currentAmmo == 0)
        {            
            if (!isReloading)            
                StartCoroutine(ReloadGun());           

            else
                return;
        }

        if (canAttack && data.currentAmmo > 0)
        {
            CreateBullet();

            StartCoroutine(AttackCooldown(data.attackRate));
        }
    }

    protected virtual void CreateBullet()
    {
        bullet = objectPooler.GetPooledObject(data.type);

        bullet.transform.position = bulletSpawn.position;

        data.currentAmmo--;
    }
    
    private IEnumerator ReloadGun()
    {
        
        isReloading = true;

        yield return new WaitForSeconds(data.reloadTime);

        isReloading = false;

        data.currentAmmo = data.maxAmmo;
    }
}
