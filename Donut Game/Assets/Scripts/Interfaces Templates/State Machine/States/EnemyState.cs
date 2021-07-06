using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyState : State
{
    protected EnemyController enemyController;

    protected Vector3 playerPosition;

    protected float distanceToPlayer;
    protected float triggerRadius;
    protected float minDistanceToAttack;
    protected float remainingDistance;

    protected EnemyState(EnemyController enemyController, StateMachine stateMachine)
    {        
        this.enemyController = enemyController;
        this.stateMachine = stateMachine;

        triggerRadius = enemyController.AttController.triggerRadius;
        minDistanceToAttack = enemyController.AttController.minDistanceToAttack;
    }

    public override void Enter()
    {
    }

    public override void Exit()
    {

    }

    public override void LogicUpdate()
    {
        distanceToPlayer = enemyController.NavAgent.DistanceToPlayer;

        remainingDistance = enemyController.NavAgent.RemainingDistance;

        playerPosition = enemyController.NavAgent.PlayerPosition;
    }

}
