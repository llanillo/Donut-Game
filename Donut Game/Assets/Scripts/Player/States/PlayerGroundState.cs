using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundState : PlayerState
{
    protected float walkSpeed;
    protected float runSpeed;

    public PlayerGroundState(PlayerManager playerManager, StateMachine stateMachine) : base(playerManager, stateMachine)
    {
        walkSpeed = playerManager.playerData.baseSpeed;
        runSpeed = playerManager.playerData.runSpeed;
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();        

        // Changes to falling state if player is not touching the ground
        if (!isGrounded)
        {
            this.stateMachine.ChangeState(playerManager.FallingState);
        }
    }
}
