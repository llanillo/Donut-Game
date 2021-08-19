using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(EnemAttController))]
[RequireComponent(typeof(EnemyHealth))]
[RequireComponent(typeof(EnemyAgent))]
public class EnemyController : MonoBehaviour
{
    public List<Transform> PatrolTargets { get; set; }

    #region Controllers
    public EnemyData EnemyData;    

    public EnemAttController AttController { get; private set; }
    public EnemyHealth Health { get; private set; }
    public EnemyAgent NavAgent { get; private set; }
    #endregion    

    #region States
    private EnemyStateMachine stateMachine;

    public EnemyAttackState AttackState { get; private set; }
    public EnemyChaseState ChaseState { get; private set; }
    public EnemyPatrolState PatrolState { get; private set; }

    #endregion

    private void Awake()
    {
        // Creates new object of the player state machine
        stateMachine = new EnemyStateMachine();
        
        AttController = GetComponent<EnemAttController>();
        Health = GetComponent<EnemyHealth>();
        NavAgent = GetComponentInParent<EnemyAgent>();

        // Create new objects of all states
        AttackState = new EnemyAttackState(this, stateMachine);
        ChaseState = new EnemyChaseState(this, stateMachine);
        PatrolState = new EnemyPatrolState(this, stateMachine);
    }

    // Start is called before the first frame update
    void Start()
    {        
        ConfigurePatrolTargets();
        stateMachine.Initialize(PatrolState);
    }

    // Update is called once per frame
    void Update()
    {
        NavAgent.Movement();
        stateMachine.CurrentState.LogicUpdate();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, AttController.triggerRadius);
    }

    private void ConfigurePatrolTargets()
    {
        PatrolTargets = new List<Transform>();

        Transform childPatrol = transform.Find("Patrol Targets");

        foreach (Transform child in childPatrol)
        {
            PatrolTargets.Add(child);            
        }

        foreach (Transform child in PatrolTargets)
        {
            child.SetParent(null, true);
        }
    }
}
