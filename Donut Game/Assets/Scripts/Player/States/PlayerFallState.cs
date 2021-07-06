using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallState : PlayerState
{
    public PlayerFallState(PlayerManager playerManager, StateMachine stateMachine) : base(playerManager, stateMachine)
    {
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

        if (isGrounded)
        {
            // Check if player is pressing movement keys
            if (!this.playerInput.Equals(Vector2.zero))
            {
                // Checks if player is pressing the run key
                if (!isRunning)
                    this.stateMachine.ChangeState(playerManager.WalkState);

                else if (isRunning)
                    this.stateMachine.ChangeState(playerManager.RunState);
            }
            
            else
                this.stateMachine.ChangeState(playerManager.IdleState);
        }
    }
}
