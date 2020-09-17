// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerControls : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""e816d35d-66d2-4808-9c2a-e9169d6f682c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""1fa10814-f0d6-4168-b79c-86c9924f2d08"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grow"",
                    ""type"": ""Value"",
                    ""id"": ""0a099a39-f7fc-430d-b462-1c8ccf72e0e5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shrink"",
                    ""type"": ""Button"",
                    ""id"": ""b531a4eb-1d41-4c85-84d4-21417766d7b0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ad0bfc8a-8473-4245-93e6-d4a430302918"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.7)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""742eb8c1-b626-40ad-8199-8d66494db669"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""Hold(duration=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shrink"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f94ee63b-565e-44a0-a9b0-95dd8888800c"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Hold(duration=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e44bab66-27ce-46a0-850a-68ddf0adb7ee"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Hold(duration=0.4)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22a3c67a-e966-43cc-abae-c97ea21f9116"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""8c90be83-9027-40dc-ab95-81b1e6d6be58"",
            ""actions"": [
                {
                    ""name"": ""Join Game"",
                    ""type"": ""Button"",
                    ""id"": ""63f68a3c-86a9-40f1-af8d-f28e220a57ac"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a1a3f490-65c2-4c70-94a8-542a773de7d2"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Join Game"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Grow = m_Gameplay.FindAction("Grow", throwIfNotFound: true);
        m_Gameplay_Shrink = m_Gameplay.FindAction("Shrink", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_JoinGame = m_Menu.FindAction("Join Game", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Grow;
    private readonly InputAction m_Gameplay_Shrink;
    private readonly InputAction m_Gameplay_Jump;
    public struct GameplayActions
    {
        private PlayerControls m_Wrapper;
        public GameplayActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Grow => m_Wrapper.m_Gameplay_Grow;
        public InputAction @Shrink => m_Wrapper.m_Gameplay_Shrink;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                Grow.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                Grow.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                Grow.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                Shrink.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShrink;
                Shrink.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShrink;
                Shrink.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShrink;
                Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                Grow.started += instance.OnGrow;
                Grow.performed += instance.OnGrow;
                Grow.canceled += instance.OnGrow;
                Shrink.started += instance.OnShrink;
                Shrink.performed += instance.OnShrink;
                Shrink.canceled += instance.OnShrink;
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.canceled += instance.OnJump;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_JoinGame;
    public struct MenuActions
    {
        private PlayerControls m_Wrapper;
        public MenuActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @JoinGame => m_Wrapper.m_Menu_JoinGame;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                JoinGame.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnJoinGame;
                JoinGame.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnJoinGame;
                JoinGame.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnJoinGame;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                JoinGame.started += instance.OnJoinGame;
                JoinGame.performed += instance.OnJoinGame;
                JoinGame.canceled += instance.OnJoinGame;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnGrow(InputAction.CallbackContext context);
        void OnShrink(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnJoinGame(InputAction.CallbackContext context);
    }
}
