using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DamageFlash))]
public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;

    private DamageFlash damageFlash;

    public delegate void UpdateCanvasDelegate(float damage);
    public event UpdateCanvasDelegate heartsDelegate;

    public float currentHealth { get; private set; }
    public float maxHealth { get; private set; }
    public float immunityTime { get; private set; }

    public bool canBeAttacked { get; set; }

    private void Awake() => AsignVariables();

    public void ReduceHealth (float damage)
    {        
        if (canBeAttacked && currentHealth > 0)
        {
            currentHealth -= damage;

            // Updates canvas hearts
            if (heartsDelegate != null)
                heartsDelegate(damage);

            // Start flash damage blink
            damageFlash.StartFlash();
        }

        if (currentHealth <= 0)
            Debug.Log("Player death");
    }

    public void Heal (float healing)
    {
        currentHealth += healing;

        if (currentHealth >= maxHealth)
            currentHealth = maxHealth;
    }

    private void AsignVariables()
    {
        damageFlash = GetComponent<DamageFlash>();

        currentHealth = playerData.health;
        maxHealth = playerData.maxHealth;

        immunityTime = playerData.immunityTime;
        canBeAttacked = true;
    }
}
