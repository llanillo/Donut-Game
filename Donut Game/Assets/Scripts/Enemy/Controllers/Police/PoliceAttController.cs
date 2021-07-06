using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceAttController : EnemAttController
{
    private Vector3 playerDirection;
    private BasicGun policeGun;
    private GrenadeLauncher policeLauncher;

    private void Awake()
    {
        policeGun = GetComponentInChildren<BasicGun>();
        policeLauncher = GetComponentInChildren<GrenadeLauncher>();
    }

    public override void Attack(Vector3 playerPosition)
    {            
        float shortRange = minDistanceToAttack / 1.2f;
        float distanceToPlayer = Vector3.Distance(transform.position, playerPosition);

        if (distanceToPlayer >= shortRange)
        {
            playerDirection = playerPosition - policeGun.bulletSpawn.position;
            policeLauncher.Attack(playerDirection);
        }

        else
        {
            playerDirection = Vector3.Normalize(playerPosition - policeGun.bulletSpawn.position);            
            policeGun.Attack(playerDirection);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, triggerRadius);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, minDistanceToAttack);
    }
}
