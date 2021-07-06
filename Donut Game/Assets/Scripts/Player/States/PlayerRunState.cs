using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunState : PlayerGroundState
{
    public PlayerRunState(PlayerManager playerManager, StateMachine stateMachine) : base(playerManager, stateMachine)
    {
    }

    public override void Enter()
    {
        base.Enter();

        playerManager.Movement.PlayerHorizontalSpeed = runSpeed;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        // Check if player is not pressing movement keys
        if (this.playerInput.Equals(Vector2.zero))
        {
            this.stateMachine.ChangeState(playerManager.IdleState);
        }

        else
        {
            // Change to walk state if player is not pressing the run key
            if (!isRunning)
                this.stateMachine.ChangeState(playerManager.WalkState);

            // Change to dodge state if player pressed the dodge key
            if (isDodging)
            {
                this.stateMachine.ChangeState(playerManager.DodgeState);
            }
        }
    }
}
