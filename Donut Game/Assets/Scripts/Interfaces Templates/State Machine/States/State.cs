using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected StateMachine stateMachine;
    public virtual void Enter()
    {

    }

    public virtual void Exit()
    {

    }

    public virtual void LogicUpdate()
    {

    }
}
