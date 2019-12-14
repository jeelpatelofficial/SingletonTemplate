using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : IManager
{
    #region Singleton
    private static InputManager instance;
    private InputManager() { }
    public static InputManager Instance { get { return instance ?? (instance = new InputManager()); } }
    #endregion
    public enum InputPressType { None, FirstPress, Held, Release }

    public void Initialize()
    {
        throw new System.NotImplementedException();
    }

    public void PhysicsRefresh()
    {
        throw new System.NotImplementedException();
    }

    public void PostInitialize()
    {
        throw new System.NotImplementedException();
    }

    public void Refresh()
    {
        throw new System.NotImplementedException();
    }
}
