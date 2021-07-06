using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newCharacterData", menuName = "Data/Enemy Data")]
public class EnemyData : ScriptableObject
{
    [Header("Health")]
    public float maxHealth;
    public float immunityTime;

    [Header("Movement")]
    public float baseSpeed;
    public float runSpeed;
}
