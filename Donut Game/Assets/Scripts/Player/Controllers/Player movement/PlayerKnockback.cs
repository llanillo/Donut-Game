using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerKnockback : MovementModifier
{
    private PlayerMovement playerMove;

    private bool canKnockback = true;

    protected override void OnEnable()
    {
        base.OnEnable();
        playerMove = GetComponent<PlayerMovement>();
    }

    public void Knockback(Vector3 knockbackDirection, float strength, float length)
    {
        if (canKnockback)
        {
            playerMove.CanMove = false;
            Value = knockbackDirection * strength;
            StartCoroutine(knockbackCooldown(length));
        }
    }

    private IEnumerator knockbackCooldown(float length)
    {
        canKnockback = false;

        yield return new WaitForSeconds(length);

        Value = Vector3.zero;

        playerMove.CanMove = true;

        canKnockback = true;
    }
}
