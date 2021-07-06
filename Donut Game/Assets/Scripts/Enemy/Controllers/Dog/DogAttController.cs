using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DogAttController : EnemAttController
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private float timeBeforeAttack;
    [SerializeField] private float jumpForce;

    private bool canAttack = true;

    private NavMeshAgent agent;
    private Rigidbody rigidBody;

    private void Awake() => GetComponents();

    public override void Attack(Vector3 playerPosition)
    {
        if (canAttack)
        {
            agent.enabled = false;
            StartCoroutine(JumpAttack(playerPosition));
        }
    }

    private IEnumerator JumpAttack(Vector3 playerPosition)
    {
        yield return new WaitForSecondsRealtime(timeBeforeAttack);
        //yield return new WaitForFixedUpdate();

        Vector3 attackDirection = playerPosition - transform.position;
        attackDirection.y = 0;

        rigidBody.AddForce(attackDirection.normalized * jumpForce);        

        agent.enabled = true;

        canAttack = false;

        yield return new WaitForSeconds(attackCooldown);

        canAttack = true;
    }

    private void GetComponents()
    {
        agent = GetComponent<NavMeshAgent>();
        rigidBody = GetComponent<Rigidbody>();
    }
}
