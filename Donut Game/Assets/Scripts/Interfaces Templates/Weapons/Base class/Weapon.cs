using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    protected ObjectPooler objectPooler;
    protected bool canAttack = true;    
    
    public WeaponData data;
    public bool isGun;

    private void Start() => FindObjectPooler();

    public virtual void Attack (Vector3 attackDirection) { }

    protected IEnumerator AttackCooldown(float attackRate)
    {
        canAttack = false;

        yield return new WaitForSeconds(attackRate);

        canAttack = true;
    }

    private void FindObjectPooler()
    {
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        objectPooler = gameController.GetComponent<ObjectPooler>();
    }
}
