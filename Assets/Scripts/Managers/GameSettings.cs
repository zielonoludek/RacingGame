using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameSettings", menuName = "GameSettings", order = 1)]

public class GameSettings : ScriptableObject
{
    [Header("Scenes")]
    public string MainMenu = "MainMenu";
    public string L1 = "L1";
    public string L2 = "L2";
    public string L3 = "L3";

    public bool isGamePaused;
    public bool isLevelRunning;
}