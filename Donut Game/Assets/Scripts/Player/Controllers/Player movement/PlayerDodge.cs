using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerDodge : MovementModifier
{
    private PlayerManager playerManager;
    private CharacterController controller;

    private float dodgeSpeed;
    private float dodgeLength;
    private float dodgeCooldown;

    private bool canDodge = true;

    // Start is called before the first frame update
    void Start()
    {                
        controller = GetComponent<CharacterController>();
        playerManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerManager>();

        dodgeSpeed = playerManager.playerData.dodgeSpeed;
        dodgeLength = playerManager.playerData.dodgeLength;
        dodgeCooldown = playerManager.playerData.dodgeCooldown;
    }

    public void DodgeDirection()
    {       
        if (canDodge)
        {            
            Vector3 lastPlayerDirection = Vector3.Normalize(controller.velocity);

            Value = lastPlayerDirection * dodgeSpeed;
            
            DodgeCooldown();
        }
        
    }     

    private void DodgeCooldown()
    {
        StartCoroutine(ResetDodge());
    }

    IEnumerator ResetDodge()
    {
        canDodge = false;
        playerManager.Health.canBeAttacked = false;

        yield return new WaitForSeconds(dodgeLength);
        
        Value = Vector3.zero;
        playerManager.Health.canBeAttacked = true;

        yield return new WaitForSeconds(dodgeCooldown);

        canDodge = true;
    }
}
