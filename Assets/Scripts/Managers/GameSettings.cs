using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameSettings", menuName = "GameSettings", order = 1)]

public class GameSettings : ScriptableObject
{
    [Header("Scenes")]
    public string MainMenu = "MainMenu";

    public bool isGamePaused;
    public bool isLevelRuning;
}