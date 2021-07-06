using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAgent : MonoBehaviour
{
    [SerializeField] private float rotationSmoothness;

    public NavMeshAgent Agent { get; private set; }

    #region Target Information
    private Transform player;

    public float RemainingDistance { get; private set; }
    public float DistanceToPlayer { get; private set; }

    public Vector3 PlayerPosition { get; private set; }
    public Vector3 TargetPosition { get; set; }
    public Vector3 LookDirection { get; set; }
    #endregion

    private void Awake() => Agent = GetComponent<NavMeshAgent>();

    private void Start() => player = GameObject.FindWithTag("Player").transform;

    public void Movement()
    {
        GetTargetInfo();

        if (Agent.enabled)
            MoveToTarget();
    }

    // Rotate enemy to the direction of the target position
    private void MoveToTarget()
    {
        Agent.SetDestination(TargetPosition);

        LookTarget();
    }

    private void LookTarget()
    {
        Vector3 look = LookDirection - transform.position;

        Quaternion rotation = Quaternion.LookRotation(look);

        rotation.x = 0;
        rotation.z = 0;

        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSmoothness * Time.deltaTime);
    }

    public void GetTargetInfo()
    {
        PlayerPosition = player.position;

        DistanceToPlayer = Vector3.Distance(transform.position, PlayerPosition);

        if (Agent.enabled)
            RemainingDistance = Agent.remainingDistance;
    }
}
