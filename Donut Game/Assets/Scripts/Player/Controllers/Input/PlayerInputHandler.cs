using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    public Vector2 MovementInput { get; private set; }
    public Vector2 MousePosition { get; private set; }

    public float IsSwitchingByScroll { get; private set; }
    public bool IsSwitchingByKey { get; private set; }
    public bool IsAttacking { get; private set; }
    public bool IsRunning { get; private set; }
    public bool IsDodging { get; private set; }

    public void OnFireInput(InputAction.CallbackContext context)
    {
        if (context.started)
            IsAttacking = true;

        if (context.canceled)
            IsAttacking = false;        
    }

    public void OnSwitchWeapScroll(InputAction.CallbackContext context)
    {
        IsSwitchingByScroll = context.ReadValue<float>();        
    }

    public void OnSwitchWeapKey (InputAction.CallbackContext context)
    {        
        if (context.performed)
            IsSwitchingByKey = true;
        if (context.canceled)
            IsSwitchingByKey = false;        
    }

    public void OnMouseMovement(InputAction.CallbackContext context)
    {
        MousePosition = context.ReadValue<Vector2>();
    }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        MovementInput = context.ReadValue<Vector2>();        
    }

    public void OnRunInput(InputAction.CallbackContext context)
    {
        if (context.started)
            IsRunning = true;

        if (context.canceled)
            IsRunning = false;
    }

    public void OnDodgeInput(InputAction.CallbackContext context)
    {
        if (context.started)
            IsDodging = true;
        if (context.canceled)
            IsDodging = false;
    }
}
