using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackState : EnemyState
{
    public EnemyAttackState(EnemyController enemyController, StateMachine stateMachine) : base(enemyController, stateMachine)
    {
    }

    public override void Enter()
    {
        base.Enter();
        RandomizeAttackMovement();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        
        if (distanceToPlayer > minDistanceToAttack)
        {
            enemyController.NavAgent.Agent.speed = enemyController.EnemyData.runSpeed;

            stateMachine.ChangeState(enemyController.ChaseState);

            if (distanceToPlayer > triggerRadius)
                stateMachine.ChangeState(enemyController.PatrolState);
        }

        else
        {                            
            enemyController.NavAgent.LookDirection = playerPosition;

            // Enemy attack function
            enemyController.AttController.Attack(playerPosition);
        }
    }

    private void RandomizeAttackMovement()
    {
        enemyController.NavAgent.Agent.speed = enemyController.EnemyData.baseSpeed;

        Vector3 playerDirection = playerPosition - enemyController.transform.position;        

        float firstRandom = Random.Range(-100, 100);
        float secondRandom = Random.Range(-100, 100);

        enemyController.NavAgent.TargetPosition = new Vector3(playerDirection.x + firstRandom, 0, playerDirection.z + secondRandom);   
    }
}
