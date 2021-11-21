// GENERATED AUTOMATICALLY FROM 'Assets/Input/Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Atoria
{
    public class @Input : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Input()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""77378d1f-6a26-4b9a-885c-d53b5705c314"",
            ""actions"": [
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""14754c97-6b4e-4488-8533-61d05b40c477"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""3633357a-95b0-4759-8c3a-c348edb0fb39"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""03d07798-8392-4b4f-8bd0-b1e564ce673d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shift"",
                    ""type"": ""Button"",
                    ""id"": ""a194de99-7fdd-4310-b650-81361896e6da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""33dfcfa4-5dfd-462e-807c-2c1a29f657bd"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + Mouse"",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80547e2f-86e0-465a-bbba-2151fad78de1"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83b243d3-6184-455b-949b-8a61cc2169c8"",
                    ""path"": ""<Pointer>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + Mouse"",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b09ef6da-b533-47bc-82ab-9db56acf9ff1"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + Mouse"",
                    ""action"": ""Shift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard + Mouse"",
            ""bindingGroup"": ""Keyboard + Mouse"",
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
            // Main
            m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
            m_Main_MousePosition = m_Main.FindAction("MousePosition", throwIfNotFound: true);
            m_Main_LeftClick = m_Main.FindAction("LeftClick", throwIfNotFound: true);
            m_Main_RightClick = m_Main.FindAction("RightClick", throwIfNotFound: true);
            m_Main_Shift = m_Main.FindAction("Shift", throwIfNotFound: true);
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

        // Main
        private readonly InputActionMap m_Main;
        private IMainActions m_MainActionsCallbackInterface;
        private readonly InputAction m_Main_MousePosition;
        private readonly InputAction m_Main_LeftClick;
        private readonly InputAction m_Main_RightClick;
        private readonly InputAction m_Main_Shift;
        public struct MainActions
        {
            private @Input m_Wrapper;
            public MainActions(@Input wrapper) { m_Wrapper = wrapper; }
            public InputAction @MousePosition => m_Wrapper.m_Main_MousePosition;
            public InputAction @LeftClick => m_Wrapper.m_Main_LeftClick;
            public InputAction @RightClick => m_Wrapper.m_Main_RightClick;
            public InputAction @Shift => m_Wrapper.m_Main_Shift;
            public InputActionMap Get() { return m_Wrapper.m_Main; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
            public void SetCallbacks(IMainActions instance)
            {
                if (m_Wrapper.m_MainActionsCallbackInterface != null)
                {
                    @MousePosition.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMousePosition;
                    @MousePosition.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMousePosition;
                    @MousePosition.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMousePosition;
                    @LeftClick.started -= m_Wrapper.m_MainActionsCallbackInterface.OnLeftClick;
                    @LeftClick.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnLeftClick;
                    @LeftClick.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnLeftClick;
                    @RightClick.started -= m_Wrapper.m_MainActionsCallbackInterface.OnRightClick;
                    @RightClick.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnRightClick;
                    @RightClick.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnRightClick;
                    @Shift.started -= m_Wrapper.m_MainActionsCallbackInterface.OnShift;
                    @Shift.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnShift;
                    @Shift.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnShift;
                }
                m_Wrapper.m_MainActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @MousePosition.started += instance.OnMousePosition;
                    @MousePosition.performed += instance.OnMousePosition;
                    @MousePosition.canceled += instance.OnMousePosition;
                    @LeftClick.started += instance.OnLeftClick;
                    @LeftClick.performed += instance.OnLeftClick;
                    @LeftClick.canceled += instance.OnLeftClick;
                    @RightClick.started += instance.OnRightClick;
                    @RightClick.performed += instance.OnRightClick;
                    @RightClick.canceled += instance.OnRightClick;
                    @Shift.started += instance.OnShift;
                    @Shift.performed += instance.OnShift;
                    @Shift.canceled += instance.OnShift;
                }
            }
        }
        public MainActions @Main => new MainActions(this);
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard + Mouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
            }
        }
        public interface IMainActions
        {
            void OnMousePosition(InputAction.CallbackContext context);
            void OnLeftClick(InputAction.CallbackContext context);
            void OnRightClick(InputAction.CallbackContext context);
            void OnShift(InputAction.CallbackContext context);
        }
    }
}
