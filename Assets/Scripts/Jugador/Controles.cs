//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Controles.inputactions
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

namespace Jugador
{
    public partial class @Controles : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Controles()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controles"",
    ""maps"": [
        {
            ""name"": ""Principal"",
            ""id"": ""669b0d30-2e30-44e6-983d-9922ead7866f"",
            ""actions"": [
                {
                    ""name"": ""Camara Libre Movimiento"",
                    ""type"": ""Value"",
                    ""id"": ""aaec9391-0d14-4ae3-a2af-dd6feaeadd0f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Camara Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""272bc560-4c65-4da2-8801-eb3565610653"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Bola Potencia"",
                    ""type"": ""Button"",
                    ""id"": ""112cbe11-f309-4241-8f36-8918326ad498"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Bola Rotar Izquierda"",
                    ""type"": ""Button"",
                    ""id"": ""8040d91c-61f1-45ab-9a5c-58f5b4874306"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Bola Rotar Derecha"",
                    ""type"": ""Button"",
                    ""id"": ""f26d05fe-243c-4287-ac1a-acd8b7785676"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Camara Modo"",
                    ""type"": ""Button"",
                    ""id"": ""87f48b90-af73-45a1-a37e-cc6a55574d1a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cambiar Palo"",
                    ""type"": ""Button"",
                    ""id"": ""cf348f9f-c0ff-4b8d-a5c7-c9c8095b9a8b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ffc7997a-9340-4eca-915d-e609a1b264f6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camara Libre Movimiento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""03d1ef89-4150-4939-8d9d-14c40903a5f1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camara Libre Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f465bc5b-7fc2-4331-a8dc-c963718503c5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camara Libre Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b56c8a17-773a-4121-b9e6-db239ececc45"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camara Libre Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9d8a775c-689d-4d58-8c54-8a97c826bcb1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camara Libre Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3767fa31-0b17-4f88-bbd8-56baf285d290"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camara Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac46885d-918c-4bf8-bc84-e4b25c32fe8e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bola Potencia"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7019b5d-1868-45eb-a72a-362d8e27e00a"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bola Rotar Izquierda"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d2c9a28-1ffe-4c10-8025-44f9a8f48f00"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bola Rotar Derecha"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3fba34e4-2129-405a-8c1d-c430e65d05d8"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camara Modo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9f71d36-7b2f-4ad1-8fea-1c2541ab89d8"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cambiar Palo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Principal
            m_Principal = asset.FindActionMap("Principal", throwIfNotFound: true);
            m_Principal_CamaraLibreMovimiento = m_Principal.FindAction("Camara Libre Movimiento", throwIfNotFound: true);
            m_Principal_CamaraZoom = m_Principal.FindAction("Camara Zoom", throwIfNotFound: true);
            m_Principal_BolaPotencia = m_Principal.FindAction("Bola Potencia", throwIfNotFound: true);
            m_Principal_BolaRotarIzquierda = m_Principal.FindAction("Bola Rotar Izquierda", throwIfNotFound: true);
            m_Principal_BolaRotarDerecha = m_Principal.FindAction("Bola Rotar Derecha", throwIfNotFound: true);
            m_Principal_CamaraModo = m_Principal.FindAction("Camara Modo", throwIfNotFound: true);
            m_Principal_CambiarPalo = m_Principal.FindAction("Cambiar Palo", throwIfNotFound: true);
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

        // Principal
        private readonly InputActionMap m_Principal;
        private IPrincipalActions m_PrincipalActionsCallbackInterface;
        private readonly InputAction m_Principal_CamaraLibreMovimiento;
        private readonly InputAction m_Principal_CamaraZoom;
        private readonly InputAction m_Principal_BolaPotencia;
        private readonly InputAction m_Principal_BolaRotarIzquierda;
        private readonly InputAction m_Principal_BolaRotarDerecha;
        private readonly InputAction m_Principal_CamaraModo;
        private readonly InputAction m_Principal_CambiarPalo;
        public struct PrincipalActions
        {
            private @Controles m_Wrapper;
            public PrincipalActions(@Controles wrapper) { m_Wrapper = wrapper; }
            public InputAction @CamaraLibreMovimiento => m_Wrapper.m_Principal_CamaraLibreMovimiento;
            public InputAction @CamaraZoom => m_Wrapper.m_Principal_CamaraZoom;
            public InputAction @BolaPotencia => m_Wrapper.m_Principal_BolaPotencia;
            public InputAction @BolaRotarIzquierda => m_Wrapper.m_Principal_BolaRotarIzquierda;
            public InputAction @BolaRotarDerecha => m_Wrapper.m_Principal_BolaRotarDerecha;
            public InputAction @CamaraModo => m_Wrapper.m_Principal_CamaraModo;
            public InputAction @CambiarPalo => m_Wrapper.m_Principal_CambiarPalo;
            public InputActionMap Get() { return m_Wrapper.m_Principal; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PrincipalActions set) { return set.Get(); }
            public void SetCallbacks(IPrincipalActions instance)
            {
                if (m_Wrapper.m_PrincipalActionsCallbackInterface != null)
                {
                    @CamaraLibreMovimiento.started -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnCamaraLibreMovimiento;
                    @CamaraLibreMovimiento.performed -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnCamaraLibreMovimiento;
                    @CamaraLibreMovimiento.canceled -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnCamaraLibreMovimiento;
                    @CamaraZoom.started -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnCamaraZoom;
                    @CamaraZoom.performed -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnCamaraZoom;
                    @CamaraZoom.canceled -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnCamaraZoom;
                    @BolaPotencia.started -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnBolaPotencia;
                    @BolaPotencia.performed -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnBolaPotencia;
                    @BolaPotencia.canceled -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnBolaPotencia;
                    @BolaRotarIzquierda.started -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnBolaRotarIzquierda;
                    @BolaRotarIzquierda.performed -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnBolaRotarIzquierda;
                    @BolaRotarIzquierda.canceled -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnBolaRotarIzquierda;
                    @BolaRotarDerecha.started -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnBolaRotarDerecha;
                    @BolaRotarDerecha.performed -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnBolaRotarDerecha;
                    @BolaRotarDerecha.canceled -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnBolaRotarDerecha;
                    @CamaraModo.started -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnCamaraModo;
                    @CamaraModo.performed -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnCamaraModo;
                    @CamaraModo.canceled -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnCamaraModo;
                    @CambiarPalo.started -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnCambiarPalo;
                    @CambiarPalo.performed -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnCambiarPalo;
                    @CambiarPalo.canceled -= m_Wrapper.m_PrincipalActionsCallbackInterface.OnCambiarPalo;
                }
                m_Wrapper.m_PrincipalActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @CamaraLibreMovimiento.started += instance.OnCamaraLibreMovimiento;
                    @CamaraLibreMovimiento.performed += instance.OnCamaraLibreMovimiento;
                    @CamaraLibreMovimiento.canceled += instance.OnCamaraLibreMovimiento;
                    @CamaraZoom.started += instance.OnCamaraZoom;
                    @CamaraZoom.performed += instance.OnCamaraZoom;
                    @CamaraZoom.canceled += instance.OnCamaraZoom;
                    @BolaPotencia.started += instance.OnBolaPotencia;
                    @BolaPotencia.performed += instance.OnBolaPotencia;
                    @BolaPotencia.canceled += instance.OnBolaPotencia;
                    @BolaRotarIzquierda.started += instance.OnBolaRotarIzquierda;
                    @BolaRotarIzquierda.performed += instance.OnBolaRotarIzquierda;
                    @BolaRotarIzquierda.canceled += instance.OnBolaRotarIzquierda;
                    @BolaRotarDerecha.started += instance.OnBolaRotarDerecha;
                    @BolaRotarDerecha.performed += instance.OnBolaRotarDerecha;
                    @BolaRotarDerecha.canceled += instance.OnBolaRotarDerecha;
                    @CamaraModo.started += instance.OnCamaraModo;
                    @CamaraModo.performed += instance.OnCamaraModo;
                    @CamaraModo.canceled += instance.OnCamaraModo;
                    @CambiarPalo.started += instance.OnCambiarPalo;
                    @CambiarPalo.performed += instance.OnCambiarPalo;
                    @CambiarPalo.canceled += instance.OnCambiarPalo;
                }
            }
        }
        public PrincipalActions @Principal => new PrincipalActions(this);
        public interface IPrincipalActions
        {
            void OnCamaraLibreMovimiento(InputAction.CallbackContext context);
            void OnCamaraZoom(InputAction.CallbackContext context);
            void OnBolaPotencia(InputAction.CallbackContext context);
            void OnBolaRotarIzquierda(InputAction.CallbackContext context);
            void OnBolaRotarDerecha(InputAction.CallbackContext context);
            void OnCamaraModo(InputAction.CallbackContext context);
            void OnCambiarPalo(InputAction.CallbackContext context);
        }
    }
}
