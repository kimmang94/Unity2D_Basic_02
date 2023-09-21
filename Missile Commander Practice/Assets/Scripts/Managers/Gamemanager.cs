using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    [SerializeField] private BulletLauncher launcherPrefab;

    private BulletLauncher launcher;

    void Start()
    {
        launcher = Instantiate(launcherPrefab);
        launcher.SetGameController(new MouseGameController());
    }


    void Update()
    {
        
    }
}
