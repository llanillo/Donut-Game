using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemAttController : MonoBehaviour
{
    public float triggerRadius;
    public float minDistanceToAttack;     

    public virtual void Attack(Vector3 playerPosition) { }
}
