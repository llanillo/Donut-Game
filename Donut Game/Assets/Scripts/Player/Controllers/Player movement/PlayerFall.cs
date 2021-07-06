using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFall : MovementModifier
{    
    private readonly float gravity = Physics.gravity.y;
    private const float gravityPull = -0.75f;

    private Vector3 playerHorVel;   

    public void Gravity()
    {
        if (moveHandler.Controller.isGrounded) // Pushes player down a little to the ground
            playerHorVel.y = gravityPull;

        else
            playerHorVel.y += gravity * Time.deltaTime;

        Value = playerHorVel;        
    }
}
