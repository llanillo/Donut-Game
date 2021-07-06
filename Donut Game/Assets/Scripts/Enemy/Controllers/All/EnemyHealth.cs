using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private EnemyData enemyData;

    private float health;
    private float immunityTime;
    private bool canBeAttacked = true;

    private void Awake() => AsignVariables();

    public void ReduceHealth(float damage)
    {
        if (canBeAttacked && health > 0)
        {
            health -= damage;
        }

        if (health <= 0)
            Debug.Log("Enemy death");
    }

    private IEnumerator AttackedCooldown()
    {
        canBeAttacked = false;

        yield return new WaitForSeconds(immunityTime);

        canBeAttacked = true;
    }

    private void AsignVariables()
    {
        enemyData = GetComponent<EnemyController>().EnemyData;

        health = enemyData.maxHealth;
        immunityTime = enemyData.immunityTime;
    }
}
