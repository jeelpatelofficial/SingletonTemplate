using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : IManager
{
    #region Singleton
    private static GameFlow instance = null;

    private GameFlow()
    {

    }

    public static GameFlow Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameFlow();
            }
            return instance;
        }
    }

    #endregion

    public void Initialize()
    {
        //throw new System.NotImplementedException();
        InputManager.Instance.Initialize();
        PlayerManager.Instance.Initialize();
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
