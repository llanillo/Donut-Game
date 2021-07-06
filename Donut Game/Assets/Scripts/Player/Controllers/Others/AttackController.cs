using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AttackController : MonoBehaviour
{
    public Weapon currentWeapon { get; set; }

    private PlayerInputHandler input;
    private PlayerRotation rotation;
    
    private void Awake()
    {
        input = GetComponent<PlayerInputHandler>();
        rotation = GetComponent<PlayerRotation>();        
    }

    private void Update()
    {        
        if(currentWeapon != null)
        {
            if (currentWeapon.isGun)
                Attack();
            else
            {
                Debug.Log("weapon controller updatte else");
            }
        }
    }

    private void Attack()
    {        
        if (input.IsAttacking)
        {            
            Vector3 shootDirection = rotation.LookDirection.normalized;            

            currentWeapon.Attack(shootDirection);            
        }
    }


}
