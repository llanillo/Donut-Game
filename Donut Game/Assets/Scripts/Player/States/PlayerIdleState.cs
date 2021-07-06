using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerGroundState
{
    public PlayerIdleState(PlayerManager playerManager, StateMachine stateMachine) : base(playerManager, stateMachine)
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

        // Check if player is pressing movement keys
        if (!this.playerInput.Equals(Vector2.zero))
        {
            // Checks player current speed to change to walk or run state
            if (!playerManager.InputHandler.IsRunning)
                this.stateMachine.ChangeState(playerManager.WalkState);

            else if (playerManager.InputHandler.IsRunning)
                this.stateMachine.ChangeState(playerManager.RunState);
        }
    }    
}
