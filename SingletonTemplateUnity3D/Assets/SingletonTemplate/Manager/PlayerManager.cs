using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : IManager
{
    #region Singleton
    private static PlayerManager instance;
    private PlayerManager() { }
    public static PlayerManager Instance { get { return instance ?? (instance = new PlayerManager()); } }
    #endregion
    public PlayerController player;

    public void Initialize()
    {
        //throw new System.NotImplementedException();
        player = GameObject.FindObjectOfType<PlayerController>();
    }

    public void PostInitialize()
    {
        throw new System.NotImplementedException();
    }

    public void Refresh()
    {
        throw new System.NotImplementedException();
    }

    public void PhysicsRefresh()
    {
        throw new System.NotImplementedException();
    }
}
