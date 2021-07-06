using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDodgeState : PlayerGroundState
{
    public PlayerDodgeState(PlayerManager playerManager, StateMachine stateMachine) : base(playerManager, stateMachine)
    {
    }

    public override void Enter()
    {
        base.Enter();

        playerManager.DodgeMovement.DodgeDirection();

        // Change player to idle state after the dodge action
        // (if player kepts moving, he wont notice the idle because it will last a frame)
        this.stateMachine.ChangeState(playerManager.IdleState);
    }

    public override void Exit()
    {
        base.Exit();
    }

}
