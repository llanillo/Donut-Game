using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine
{
    public State CurrentState { get; private set; }

    public virtual void Initialize(State newState)
    {
        CurrentState = newState;
        CurrentState.Enter();
    }

    public virtual void ChangeState(State newState)
    {
        CurrentState.Exit();

        CurrentState = newState;
        CurrentState.Enter();
    }
   
}
