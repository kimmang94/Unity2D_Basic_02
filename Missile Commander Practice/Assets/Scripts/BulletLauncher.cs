using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    private IGameController controller;

    public void SetGameController(IGameController controller)
    {
        this.controller = controller;
    }

    private void Update()
    {
        if (controller != null)
        {
            if (controller.FireButtonPressed())
            {
                Debug.Log("Fired a bullt");
            }
        }
        else
        {
            Debug.LogError("Controller is Null");
        }

    }
}
