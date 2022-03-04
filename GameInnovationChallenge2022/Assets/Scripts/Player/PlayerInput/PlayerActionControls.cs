//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/PlayerActionControls.inputactions
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

public partial class @PlayerActionControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActionControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActionControls"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""ca960391-4744-4199-8134-bd92c6b81911"",
            ""actions"": [
                {
                    ""name"": ""VerticalMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""378173bb-0e9b-4244-a6aa-a3620be43a7d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""Button"",
                    ""id"": ""4ed25a0a-323f-4da2-aac5-6a2f7eada922"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlayerFacing"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f7bcf6c9-433e-42ad-b7fc-a11c942da173"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlayerFireWeapon"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2c5bb378-bb9a-4dc2-b9cb-7041f53723e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b27e2951-9176-40e1-885f-a40ea7eedf16"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4acae279-8db6-4704-944e-1dee748bf3b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7380b79f-c5bf-4863-9144-08d3fd8e66a2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Map"",
                    ""type"": ""PassThrough"",
                    ""id"": ""93297546-14a9-4780-aad1-f1585f57f7f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""79601d5b-c0db-4ab1-88a7-7bdf53f6f900"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""EnemyDefensiveWeapon"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e944a2e2-fbd3-46e9-b6c0-17f0ad587e2c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""VerticalMovement"",
                    ""id"": ""1a67c3e8-855e-4ea3-8d22-08c3086ff7db"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""fb802515-5136-4319-a474-2b1fcc76fd07"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Movement"",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7cf89da6-8da5-4709-bcb6-2afa544b1ff5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Movement"",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""HorizontalMovement"",
                    ""id"": ""438e8024-418b-4f59-b8e0-6731fc00470c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""89520363-fc7d-4299-9a21-da6581b05500"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Movement"",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5f5739be-35d0-4475-83b8-7a0b9c11ee3b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Movement"",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1b39727c-0382-45b2-a005-d65414cac22a"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerFacing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa840f3a-fd55-489a-a6af-62dc9413e7f1"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerFireWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30a35ed5-33c0-4157-ad41-ea8bd768c3da"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3ca38a2-29e3-4463-b459-79ce7b84d1c7"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""939ec1c3-46e8-48d8-8886-b3f0540b2f0f"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3fc96c6d-10b3-4678-b642-23289eff44c6"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Map"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16cb132a-2cc1-470d-a94f-9325e2b9fa91"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a928e95f-2af7-4695-a7d0-700dd9fc8822"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": ""Press(pressPoint=1.401298E-45,behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78ebaf7d-e8a5-4b21-baca-76e63184a7ca"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnemyDefensiveWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""DebugControls"",
            ""id"": ""c863753c-5e3f-4886-b3b6-bf7f46a8e3bf"",
            ""actions"": [
                {
                    ""name"": ""HealthLoss"",
                    ""type"": ""PassThrough"",
                    ""id"": ""27eb98cf-120c-4acd-aa30-4e89c894270d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""486273f0-af5e-41b9-a104-a389a112acc2"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HealthLoss"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_VerticalMovement = m_PlayerControls.FindAction("VerticalMovement", throwIfNotFound: true);
        m_PlayerControls_HorizontalMovement = m_PlayerControls.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_PlayerControls_PlayerFacing = m_PlayerControls.FindAction("PlayerFacing", throwIfNotFound: true);
        m_PlayerControls_PlayerFireWeapon = m_PlayerControls.FindAction("PlayerFireWeapon", throwIfNotFound: true);
        m_PlayerControls_Interact = m_PlayerControls.FindAction("Interact", throwIfNotFound: true);
        m_PlayerControls_Pause = m_PlayerControls.FindAction("Pause", throwIfNotFound: true);
        m_PlayerControls_Inventory = m_PlayerControls.FindAction("Inventory", throwIfNotFound: true);
        m_PlayerControls_Map = m_PlayerControls.FindAction("Map", throwIfNotFound: true);
        m_PlayerControls_Jump = m_PlayerControls.FindAction("Jump", throwIfNotFound: true);
        m_PlayerControls_EnemyDefensiveWeapon = m_PlayerControls.FindAction("EnemyDefensiveWeapon", throwIfNotFound: true);
        // DebugControls
        m_DebugControls = asset.FindActionMap("DebugControls", throwIfNotFound: true);
        m_DebugControls_HealthLoss = m_DebugControls.FindAction("HealthLoss", throwIfNotFound: true);
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

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_VerticalMovement;
    private readonly InputAction m_PlayerControls_HorizontalMovement;
    private readonly InputAction m_PlayerControls_PlayerFacing;
    private readonly InputAction m_PlayerControls_PlayerFireWeapon;
    private readonly InputAction m_PlayerControls_Interact;
    private readonly InputAction m_PlayerControls_Pause;
    private readonly InputAction m_PlayerControls_Inventory;
    private readonly InputAction m_PlayerControls_Map;
    private readonly InputAction m_PlayerControls_Jump;
    private readonly InputAction m_PlayerControls_EnemyDefensiveWeapon;
    public struct PlayerControlsActions
    {
        private @PlayerActionControls m_Wrapper;
        public PlayerControlsActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @VerticalMovement => m_Wrapper.m_PlayerControls_VerticalMovement;
        public InputAction @HorizontalMovement => m_Wrapper.m_PlayerControls_HorizontalMovement;
        public InputAction @PlayerFacing => m_Wrapper.m_PlayerControls_PlayerFacing;
        public InputAction @PlayerFireWeapon => m_Wrapper.m_PlayerControls_PlayerFireWeapon;
        public InputAction @Interact => m_Wrapper.m_PlayerControls_Interact;
        public InputAction @Pause => m_Wrapper.m_PlayerControls_Pause;
        public InputAction @Inventory => m_Wrapper.m_PlayerControls_Inventory;
        public InputAction @Map => m_Wrapper.m_PlayerControls_Map;
        public InputAction @Jump => m_Wrapper.m_PlayerControls_Jump;
        public InputAction @EnemyDefensiveWeapon => m_Wrapper.m_PlayerControls_EnemyDefensiveWeapon;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @VerticalMovement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnVerticalMovement;
                @VerticalMovement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnVerticalMovement;
                @VerticalMovement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnVerticalMovement;
                @HorizontalMovement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnHorizontalMovement;
                @PlayerFacing.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPlayerFacing;
                @PlayerFacing.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPlayerFacing;
                @PlayerFacing.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPlayerFacing;
                @PlayerFireWeapon.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPlayerFireWeapon;
                @PlayerFireWeapon.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPlayerFireWeapon;
                @PlayerFireWeapon.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPlayerFireWeapon;
                @Interact.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInteract;
                @Pause.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
                @Inventory.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInventory;
                @Map.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMap;
                @Map.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMap;
                @Map.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMap;
                @Jump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @EnemyDefensiveWeapon.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnEnemyDefensiveWeapon;
                @EnemyDefensiveWeapon.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnEnemyDefensiveWeapon;
                @EnemyDefensiveWeapon.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnEnemyDefensiveWeapon;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @VerticalMovement.started += instance.OnVerticalMovement;
                @VerticalMovement.performed += instance.OnVerticalMovement;
                @VerticalMovement.canceled += instance.OnVerticalMovement;
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
                @PlayerFacing.started += instance.OnPlayerFacing;
                @PlayerFacing.performed += instance.OnPlayerFacing;
                @PlayerFacing.canceled += instance.OnPlayerFacing;
                @PlayerFireWeapon.started += instance.OnPlayerFireWeapon;
                @PlayerFireWeapon.performed += instance.OnPlayerFireWeapon;
                @PlayerFireWeapon.canceled += instance.OnPlayerFireWeapon;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
                @Map.started += instance.OnMap;
                @Map.performed += instance.OnMap;
                @Map.canceled += instance.OnMap;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @EnemyDefensiveWeapon.started += instance.OnEnemyDefensiveWeapon;
                @EnemyDefensiveWeapon.performed += instance.OnEnemyDefensiveWeapon;
                @EnemyDefensiveWeapon.canceled += instance.OnEnemyDefensiveWeapon;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);

    // DebugControls
    private readonly InputActionMap m_DebugControls;
    private IDebugControlsActions m_DebugControlsActionsCallbackInterface;
    private readonly InputAction m_DebugControls_HealthLoss;
    public struct DebugControlsActions
    {
        private @PlayerActionControls m_Wrapper;
        public DebugControlsActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @HealthLoss => m_Wrapper.m_DebugControls_HealthLoss;
        public InputActionMap Get() { return m_Wrapper.m_DebugControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugControlsActions set) { return set.Get(); }
        public void SetCallbacks(IDebugControlsActions instance)
        {
            if (m_Wrapper.m_DebugControlsActionsCallbackInterface != null)
            {
                @HealthLoss.started -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnHealthLoss;
                @HealthLoss.performed -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnHealthLoss;
                @HealthLoss.canceled -= m_Wrapper.m_DebugControlsActionsCallbackInterface.OnHealthLoss;
            }
            m_Wrapper.m_DebugControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HealthLoss.started += instance.OnHealthLoss;
                @HealthLoss.performed += instance.OnHealthLoss;
                @HealthLoss.canceled += instance.OnHealthLoss;
            }
        }
    }
    public DebugControlsActions @DebugControls => new DebugControlsActions(this);
    public interface IPlayerControlsActions
    {
        void OnVerticalMovement(InputAction.CallbackContext context);
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnPlayerFacing(InputAction.CallbackContext context);
        void OnPlayerFireWeapon(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnMap(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnEnemyDefensiveWeapon(InputAction.CallbackContext context);
    }
    public interface IDebugControlsActions
    {
        void OnHealthLoss(InputAction.CallbackContext context);
    }
}