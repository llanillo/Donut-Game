using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newCharacterData", menuName = "Data/Player Data")]
public class PlayerData : ScriptableObject
{
    [Header("Health")]
    public float health;
    public float maxHealth;
    public float immunityTime;

    [Header("Movement")]
    public float baseSpeed;
    public float runSpeed;

    [Header("Dodge")]
    public float dodgeSpeed = 20;
    public float dodgeLength = 0.2f;
    public float dodgeCooldown = 0.5f;    
}
