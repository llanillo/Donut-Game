using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSword : Weapon
{    
    private Animator anim;
    private BoxCollider swordCollider;

    private void Awake() => GetComponents();
    
    public override void Attack(Vector3 attackDirection)
    {
        base.Attack(attackDirection);
        anim.SetBool("isAttacking", true);
        swordCollider.enabled = true;        
    }

    // It is called from the sword animation when it finishes the swing
    private void CancelAttackAnimEvent()
    {
        anim.SetBool("isAttacking", false);
    }

    private void GetComponents()
    {
        anim = GetComponent<Animator>();
        swordCollider = GetComponent<BoxCollider>();
        swordCollider.enabled = false;
    }
}
