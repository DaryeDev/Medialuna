// GENERATED AUTOMATICALLY FROM 'Assets/Controls/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""BroomBroom_Movement"",
            ""id"": ""66234e54-e82b-4c65-8783-c1bb81e38781"",
            ""actions"": [
                {
                    ""name"": ""Palante"",
                    ""type"": ""Button"",
                    ""id"": ""b07b5bf6-5d80-4133-b0e3-e2186ff57f3d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Patrás"",
                    ""type"": ""Button"",
                    ""id"": ""3a5ed928-1ad6-46a1-8008-bfa057558093"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Pal'lao(D)"",
                    ""type"": ""Button"",
                    ""id"": ""ed35b652-3929-480f-bce3-a94f852dc5ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Pal'lao(L)"",
                    ""type"": ""Button"",
                    ""id"": ""20973d09-d5a1-4d61-bd15-5a291ed4ad73"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Mirar"",
                    ""type"": ""Value"",
                    ""id"": ""d06da1b2-46bb-46e2-b68a-7da2c1be625a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b35f59d9-c24f-4ddb-b0cb-4cb132460e8a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Palante"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f26f1ed-4146-44d5-847f-6f16a45def4a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Patrás"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af76450b-f9e1-4117-8591-3e953c42862d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Pal'lao(D)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad238979-c630-4dd6-819f-31a9d17d2105"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Pal'lao(L)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a71bbc8f-05af-4d13-91b5-0a9f24e55c54"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mirar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""K&M"",
            ""bindingGroup"": ""K&M"",
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
        // BroomBroom_Movement
        m_BroomBroom_Movement = asset.FindActionMap("BroomBroom_Movement", throwIfNotFound: true);
        m_BroomBroom_Movement_Palante = m_BroomBroom_Movement.FindAction("Palante", throwIfNotFound: true);
        m_BroomBroom_Movement_Patrás = m_BroomBroom_Movement.FindAction("Patrás", throwIfNotFound: true);
        m_BroomBroom_Movement_PallaoD = m_BroomBroom_Movement.FindAction("Pal'lao(D)", throwIfNotFound: true);
        m_BroomBroom_Movement_PallaoL = m_BroomBroom_Movement.FindAction("Pal'lao(L)", throwIfNotFound: true);
        m_BroomBroom_Movement_Mirar = m_BroomBroom_Movement.FindAction("Mirar", throwIfNotFound: true);
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

    // BroomBroom_Movement
    private readonly InputActionMap m_BroomBroom_Movement;
    private IBroomBroom_MovementActions m_BroomBroom_MovementActionsCallbackInterface;
    private readonly InputAction m_BroomBroom_Movement_Palante;
    private readonly InputAction m_BroomBroom_Movement_Patrás;
    private readonly InputAction m_BroomBroom_Movement_PallaoD;
    private readonly InputAction m_BroomBroom_Movement_PallaoL;
    private readonly InputAction m_BroomBroom_Movement_Mirar;
    public struct BroomBroom_MovementActions
    {
        private @Controls m_Wrapper;
        public BroomBroom_MovementActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Palante => m_Wrapper.m_BroomBroom_Movement_Palante;
        public InputAction @Patrás => m_Wrapper.m_BroomBroom_Movement_Patrás;
        public InputAction @PallaoD => m_Wrapper.m_BroomBroom_Movement_PallaoD;
        public InputAction @PallaoL => m_Wrapper.m_BroomBroom_Movement_PallaoL;
        public InputAction @Mirar => m_Wrapper.m_BroomBroom_Movement_Mirar;
        public InputActionMap Get() { return m_Wrapper.m_BroomBroom_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BroomBroom_MovementActions set) { return set.Get(); }
        public void SetCallbacks(IBroomBroom_MovementActions instance)
        {
            if (m_Wrapper.m_BroomBroom_MovementActionsCallbackInterface != null)
            {
                @Palante.started -= m_Wrapper.m_BroomBroom_MovementActionsCallbackInterface.OnPalante;
                @Palante.performed -= m_Wrapper.m_BroomBroom_MovementActionsCallbackInterface.OnPalante;
                @Palante.canceled -= m_Wrapper.m_BroomBroom_MovementActionsCallbackInterface.OnPalante;
                @Patrás.started -= m_Wrapper.m_BroomBroom_MovementActionsCallbackInterface.OnPatrás;
                @Patrás.performed -= m_Wrapper.m_BroomBroom_MovementActionsCallbackInterface.OnPatrás;
                @Patrás.canceled -= m_Wrapper.m_BroomBroom_MovementActionsCallbackInterface.OnPatrás;
                @PallaoD.started -= m_Wrapper.m_BroomBroom_MovementActionsCallbackInterface.OnPallaoD;
                @PallaoD.performed -= m_Wrapper.m_BroomBroom_MovementActionsCallbackInterface.OnPallaoD;
                @PallaoD.canceled -= m_Wrapper.m_BroomBroom_MovementActionsCallbackInterface.OnPallaoD;
                @PallaoL.started -= m_Wrapper.m_BroomBroom_MovementActionsCallbackInterface.OnPallaoL;
                @PallaoL.performed -= m_Wrapper.m_BroomBroom_MovementActionsCallbackInterface.OnPallaoL;
                @PallaoL.canceled -= m_Wrapper.m_BroomBroom_MovementActionsCallbackInterface.OnPallaoL;
                @Mirar.started -= m_Wrapper.m_BroomBroom_MovementActionsCallbackInterface.OnMirar;
                @Mirar.performed -= m_Wrapper.m_BroomBroom_MovementActionsCallbackInterface.OnMirar;
                @Mirar.canceled -= m_Wrapper.m_BroomBroom_MovementActionsCallbackInterface.OnMirar;
            }
            m_Wrapper.m_BroomBroom_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Palante.started += instance.OnPalante;
                @Palante.performed += instance.OnPalante;
                @Palante.canceled += instance.OnPalante;
                @Patrás.started += instance.OnPatrás;
                @Patrás.performed += instance.OnPatrás;
                @Patrás.canceled += instance.OnPatrás;
                @PallaoD.started += instance.OnPallaoD;
                @PallaoD.performed += instance.OnPallaoD;
                @PallaoD.canceled += instance.OnPallaoD;
                @PallaoL.started += instance.OnPallaoL;
                @PallaoL.performed += instance.OnPallaoL;
                @PallaoL.canceled += instance.OnPallaoL;
                @Mirar.started += instance.OnMirar;
                @Mirar.performed += instance.OnMirar;
                @Mirar.canceled += instance.OnMirar;
            }
        }
    }
    public BroomBroom_MovementActions @BroomBroom_Movement => new BroomBroom_MovementActions(this);
    private int m_KMSchemeIndex = -1;
    public InputControlScheme KMScheme
    {
        get
        {
            if (m_KMSchemeIndex == -1) m_KMSchemeIndex = asset.FindControlSchemeIndex("K&M");
            return asset.controlSchemes[m_KMSchemeIndex];
        }
    }
    public interface IBroomBroom_MovementActions
    {
        void OnPalante(InputAction.CallbackContext context);
        void OnPatrás(InputAction.CallbackContext context);
        void OnPallaoD(InputAction.CallbackContext context);
        void OnPallaoL(InputAction.CallbackContext context);
        void OnMirar(InputAction.CallbackContext context);
    }
}
