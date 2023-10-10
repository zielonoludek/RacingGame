//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputSystem/ActionsEditor.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @ActionsEditor: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ActionsEditor()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ActionsEditor"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""5a218075-5684-4729-94e0-aa45a5b79039"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""38a291c1-7186-4b4f-a363-26b6dbc81591"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Acceleration"",
                    ""type"": ""Value"",
                    ""id"": ""07426c96-c19d-47ca-bf10-33bcb65120e0"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Reversing"",
                    ""type"": ""Value"",
                    ""id"": ""6bbb6457-0b83-4590-b650-fe888145222b"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""948ad805-b07b-4a15-9a56-a8d7aa1c2fea"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""65658490-1d5e-49fb-bd0d-ecfff6617b27"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fd694ba5-3127-46a9-8a7d-ca1280297f80"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d8893ee5-b693-4005-b0bf-8bc44a8d97ce"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8802852e-7cb8-4c77-bf22-6c3cc323a787"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reversing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player1"",
            ""id"": ""99d05670-6ee1-4e98-90af-0c2c6006721c"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""c59d0400-f0ba-4c64-982a-982e43d8ce1f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Acceleration"",
                    ""type"": ""Value"",
                    ""id"": ""d2fffecc-5c4c-40e9-ae3c-410da4baa454"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Reversing"",
                    ""type"": ""Value"",
                    ""id"": ""f439734a-1013-4b85-aa9d-db5c41ce7019"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f3209b75-9e84-4d1d-bec7-dfb1593550d6"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84be260d-acc9-4a72-b301-249d0b1cc0bd"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reversing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ca525abc-2df3-49cc-b15c-7bab7fc757be"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ade4fa1d-d6dd-4224-931d-0f74dc513669"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0e705d08-5b17-45a3-8916-f6c207bd122e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Acceleration = m_Player.FindAction("Acceleration", throwIfNotFound: true);
        m_Player_Reversing = m_Player.FindAction("Reversing", throwIfNotFound: true);
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_Movement = m_Player1.FindAction("Movement", throwIfNotFound: true);
        m_Player1_Acceleration = m_Player1.FindAction("Acceleration", throwIfNotFound: true);
        m_Player1_Reversing = m_Player1.FindAction("Reversing", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Acceleration;
    private readonly InputAction m_Player_Reversing;
    public struct PlayerActions
    {
        private @ActionsEditor m_Wrapper;
        public PlayerActions(@ActionsEditor wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Acceleration => m_Wrapper.m_Player_Acceleration;
        public InputAction @Reversing => m_Wrapper.m_Player_Reversing;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Acceleration.started += instance.OnAcceleration;
            @Acceleration.performed += instance.OnAcceleration;
            @Acceleration.canceled += instance.OnAcceleration;
            @Reversing.started += instance.OnReversing;
            @Reversing.performed += instance.OnReversing;
            @Reversing.canceled += instance.OnReversing;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Acceleration.started -= instance.OnAcceleration;
            @Acceleration.performed -= instance.OnAcceleration;
            @Acceleration.canceled -= instance.OnAcceleration;
            @Reversing.started -= instance.OnReversing;
            @Reversing.performed -= instance.OnReversing;
            @Reversing.canceled -= instance.OnReversing;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Player1
    private readonly InputActionMap m_Player1;
    private List<IPlayer1Actions> m_Player1ActionsCallbackInterfaces = new List<IPlayer1Actions>();
    private readonly InputAction m_Player1_Movement;
    private readonly InputAction m_Player1_Acceleration;
    private readonly InputAction m_Player1_Reversing;
    public struct Player1Actions
    {
        private @ActionsEditor m_Wrapper;
        public Player1Actions(@ActionsEditor wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player1_Movement;
        public InputAction @Acceleration => m_Wrapper.m_Player1_Acceleration;
        public InputAction @Reversing => m_Wrapper.m_Player1_Reversing;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void AddCallbacks(IPlayer1Actions instance)
        {
            if (instance == null || m_Wrapper.m_Player1ActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Player1ActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Acceleration.started += instance.OnAcceleration;
            @Acceleration.performed += instance.OnAcceleration;
            @Acceleration.canceled += instance.OnAcceleration;
            @Reversing.started += instance.OnReversing;
            @Reversing.performed += instance.OnReversing;
            @Reversing.canceled += instance.OnReversing;
        }

        private void UnregisterCallbacks(IPlayer1Actions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Acceleration.started -= instance.OnAcceleration;
            @Acceleration.performed -= instance.OnAcceleration;
            @Acceleration.canceled -= instance.OnAcceleration;
            @Reversing.started -= instance.OnReversing;
            @Reversing.performed -= instance.OnReversing;
            @Reversing.canceled -= instance.OnReversing;
        }

        public void RemoveCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayer1Actions instance)
        {
            foreach (var item in m_Wrapper.m_Player1ActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Player1ActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAcceleration(InputAction.CallbackContext context);
        void OnReversing(InputAction.CallbackContext context);
    }
    public interface IPlayer1Actions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAcceleration(InputAction.CallbackContext context);
        void OnReversing(InputAction.CallbackContext context);
    }
}
