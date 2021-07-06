using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DonutAttController : EnemAttController
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private float swordForce;

    private EnemySword donutSword;    

    private bool canAttack = true;

    private void Awake() => donutSword = GetComponentInChildren<EnemySword>();

    public override void Attack(Vector3 playerPosition)
    {
        if (canAttack)
        {
            donutSword.Attack(playerPosition);
            StartCoroutine(AttackCooldown());
        }
    }

    private IEnumerator AttackCooldown()
    {
        canAttack = false;
        yield return new WaitForSeconds(attackCooldown);
        canAttack = true;
    }
}
