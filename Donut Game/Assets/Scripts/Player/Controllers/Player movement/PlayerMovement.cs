using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerInputHandler))]
public class PlayerMovement : MovementModifier
{
    private PlayerInputHandler inputHandler;

    public float PlayerHorizontalSpeed { get; set; }
    public bool CanMove { get; set; }

    private bool wasGroundedLastFrame;    

    protected override void OnEnable()
    {
        base.OnEnable();
        inputHandler = GetComponent<PlayerInputHandler>();

        CanMove = true;
    }

    public void MovementDirection()
    {
        if (CanMove)
        {
            Vector2 playerInput = inputHandler.MovementInput;

            Vector3 playerMoveDir = new Vector3(playerInput.x, 0, playerInput.y);

            Vector3 playerMove = Vector3.ClampMagnitude(playerMoveDir, 1f);

            // Prevent player movement while falling
            if (!moveHandler.Controller.isGrounded && wasGroundedLastFrame) PlayerHorizontalSpeed = 3;

            Value = playerMove * PlayerHorizontalSpeed;

            wasGroundedLastFrame = moveHandler.Controller.isGrounded;
        }

        else
            Value = Vector3.zero;
    }
}
