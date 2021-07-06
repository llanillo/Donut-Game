using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChaseState : EnemyState
{    

    public EnemyChaseState(EnemyController enemyController, StateMachine stateMachine) : base(enemyController, stateMachine)
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

        // Chases the player if entered the trigger radius
        if (distanceToPlayer <= triggerRadius)
        {
            enemyController.NavAgent.TargetPosition = playerPosition;
            enemyController.NavAgent.LookDirection = playerPosition;

            if (distanceToPlayer <= minDistanceToAttack)
                stateMachine.ChangeState(enemyController.AttackState);
        }

        else
            stateMachine.ChangeState(enemyController.PatrolState);
    }
}
