using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour,IManager
{
    [HideInInspector] public PlayerStats stats;
    [HideInInspector] public Rigidbody rb;
    [HideInInspector] public Camera playerCam;

    public void Initialize()
    {
        //throw new System.NotImplementedException();
        stats = new PlayerStats();
        rb = GetComponent<Rigidbody>();
        playerCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();        
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
