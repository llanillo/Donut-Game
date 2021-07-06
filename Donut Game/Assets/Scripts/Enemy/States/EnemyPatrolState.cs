using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolState : EnemyState
{
    private int targetNumber;
    private int patrolTargetCount;
    
    public EnemyPatrolState(EnemyController enemyController, StateMachine stateMachine) : base(enemyController, stateMachine)
    {
    }
    public override void Enter()
    {
        base.Enter();

        patrolTargetCount = enemyController.PatrolTargets.Count;

        RandomizePatrol();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (remainingDistance <= 1f)
        {
            RandomizePatrol();            
        }

        if (distanceToPlayer <= triggerRadius)
        {
            stateMachine.ChangeState(enemyController.ChaseState);
        }
    }

    private void RandomizePatrol()
    {
        targetNumber = Random.Range(0, patrolTargetCount);        

        enemyController.NavAgent.TargetPosition = enemyController.PatrolTargets[targetNumber].position;

        enemyController.NavAgent.LookDirection = enemyController.NavAgent.TargetPosition;
    }
}
