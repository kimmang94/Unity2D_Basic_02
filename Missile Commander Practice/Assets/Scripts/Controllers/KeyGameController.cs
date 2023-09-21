using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGameController : IGameController
{
    public bool FireButtonPressed()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
}
