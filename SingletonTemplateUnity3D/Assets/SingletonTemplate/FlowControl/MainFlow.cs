using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlow : MonoBehaviour
{
    private void Awake()
    {
        GameFlow.Instance.Initialize();
    }

    private void Start()
    {
        GameFlow.Instance.PostInitialize();
    }

    private void Update()
    {
        GameFlow.Instance.Refresh();
    }

    private void FixedUpdate()
    {
        GameFlow.Instance.PhysicsRefresh();
    }

}
