// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player/Controllers/Input/Input System/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""5bd3d819-b297-4ab0-a2b5-bf3241f06b00"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""e04c5e29-d8e2-41e2-bcb9-21c46504a478"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""066b352e-a259-430c-ade7-8c309ca996b8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dodge"",
                    ""type"": ""Button"",
                    ""id"": ""cfc57a62-9ab0-4acc-852b-1130361a31ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""34c008c8-7ca3-4a99-b6c2-38b1e0b6e0c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""d732287c-2080-4434-b3f0-07228e0e0dce"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Switch Weapon (Scroll Wheel)"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1a330314-439b-4b95-b679-e810b636b5c3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Switch Weapon (Button)"",
                    ""type"": ""Button"",
                    ""id"": ""f98c8c13-7ac7-4d47-b612-f5914ff967b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""bbdde591-937a-4bcd-89ba-2b87372c33c3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""adc4a504-6730-4736-afbc-3105c69c9b8c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e8bee720-f4ce-4fa0-bd33-2cad20950c0b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4a06ff19-d0b6-4423-bd8f-4aae7006aa41"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""da94bbcc-ef48-4e11-a032-4b587fa05851"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3090e4de-b512-4f7d-a9e2-7277326f40b5"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c17f246b-c886-42a3-8c64-4438c19654de"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1e37078-2403-4b76-945f-8ae53a3c3d40"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7dddf8ff-d2d0-420d-acdd-b9a7b2225299"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf288db7-d7b4-459e-93b3-0bf27ca0298d"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Switch Weapon (Scroll Wheel)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0348cbf2-c29a-467c-a19f-2c58ce7a4f24"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Switch Weapon (Button)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_Movement = m_PlayerControls.FindAction("Movement", throwIfNotFound: true);
        m_PlayerControls_Run = m_PlayerControls.FindAction("Run", throwIfNotFound: true);
        m_PlayerControls_Dodge = m_PlayerControls.FindAction("Dodge", throwIfNotFound: true);
        m_PlayerControls_Shoot = m_PlayerControls.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerControls_Aim = m_PlayerControls.FindAction("Aim", throwIfNotFound: true);
        m_PlayerControls_SwitchWeaponScrollWheel = m_PlayerControls.FindAction("Switch Weapon (Scroll Wheel)", throwIfNotFound: true);
        m_PlayerControls_SwitchWeaponButton = m_PlayerControls.FindAction("Switch Weapon (Button)", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Movement;
    private readonly InputAction m_PlayerControls_Run;
    private readonly InputAction m_PlayerControls_Dodge;
    private readonly InputAction m_PlayerControls_Shoot;
    private readonly InputAction m_PlayerControls_Aim;
    private readonly InputAction m_PlayerControls_SwitchWeaponScrollWheel;
    private readonly InputAction m_PlayerControls_SwitchWeaponButton;
    public struct PlayerControlsActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerControlsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerControls_Movement;
        public InputAction @Run => m_Wrapper.m_PlayerControls_Run;
        public InputAction @Dodge => m_Wrapper.m_PlayerControls_Dodge;
        public InputAction @Shoot => m_Wrapper.m_PlayerControls_Shoot;
        public InputAction @Aim => m_Wrapper.m_PlayerControls_Aim;
        public InputAction @SwitchWeaponScrollWheel => m_Wrapper.m_PlayerControls_SwitchWeaponScrollWheel;
        public InputAction @SwitchWeaponButton => m_Wrapper.m_PlayerControls_SwitchWeaponButton;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Run.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRun;
                @Dodge.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDodge;
                @Dodge.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDodge;
                @Dodge.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDodge;
                @Shoot.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnShoot;
                @Aim.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAim;
                @SwitchWeaponScrollWheel.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwitchWeaponScrollWheel;
                @SwitchWeaponScrollWheel.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwitchWeaponScrollWheel;
                @SwitchWeaponScrollWheel.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwitchWeaponScrollWheel;
                @SwitchWeaponButton.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwitchWeaponButton;
                @SwitchWeaponButton.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwitchWeaponButton;
                @SwitchWeaponButton.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwitchWeaponButton;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Dodge.started += instance.OnDodge;
                @Dodge.performed += instance.OnDodge;
                @Dodge.canceled += instance.OnDodge;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @SwitchWeaponScrollWheel.started += instance.OnSwitchWeaponScrollWheel;
                @SwitchWeaponScrollWheel.performed += instance.OnSwitchWeaponScrollWheel;
                @SwitchWeaponScrollWheel.canceled += instance.OnSwitchWeaponScrollWheel;
                @SwitchWeaponButton.started += instance.OnSwitchWeaponButton;
                @SwitchWeaponButton.performed += instance.OnSwitchWeaponButton;
                @SwitchWeaponButton.canceled += instance.OnSwitchWeaponButton;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IPlayerControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnDodge(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnSwitchWeaponScrollWheel(InputAction.CallbackContext context);
        void OnSwitchWeaponButton(InputAction.CallbackContext context);
    }
}
