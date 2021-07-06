using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MovementHandler : MonoBehaviour
{
    public readonly List<MovementModifier> moveModifiers = new List<MovementModifier>();

    public CharacterController Controller { get; private set; }

    void Start() => Controller = GetComponent<CharacterController>();

    public void Move()
    {
        Vector3 movement = Vector3.zero;

        foreach (MovementModifier modifier in moveModifiers)
        {
            movement += modifier.Value;
        }

        Controller.Move(movement * Time.deltaTime);        
    }
}
