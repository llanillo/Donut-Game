using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerState : State
{    
    protected PlayerManager playerManager;

    protected Vector2 playerInput;        

    protected bool isGrounded;
    protected bool isRunning;
    protected bool isDodging;

    // Time since the state has been active
    protected float startTime;

    protected PlayerState(PlayerManager playerManager, StateMachine stateMachine)
    {
        this.playerManager = playerManager;
        this.stateMachine = stateMachine;
    }

    public override void Enter()
    {
        startTime = Time.time;
    }

    public override void Exit()
    {

    }

    public override void LogicUpdate()
    {
        // Reads player's input every frame
        playerInput = playerManager.InputHandler.MovementInput;
        
        isGrounded = playerManager.MoveHandler.Controller.isGrounded;
        isRunning = playerManager.InputHandler.IsRunning;
        isDodging = playerManager.InputHandler.IsDodging;        
    }

    public virtual void PhysicsUpdate()
    {

    }
}
