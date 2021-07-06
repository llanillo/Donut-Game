using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MovementHandler))]
public abstract class MovementModifier : MonoBehaviour
{
    protected MovementHandler moveHandler;   

    public Vector3 Value { get; protected set; }
    
    protected virtual void OnEnable()
    {
        moveHandler = GetComponent<MovementHandler>();
        moveHandler.moveModifiers.Add(this);
    }

    void OnDisable()
    {
        moveHandler.moveModifiers.Add(this);
    }
}
