using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    public static GameState instance;
    public GameSettings gameSettings;

    public void Initialize()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            LogGameState("Game Initialized");

            LoadSettings();
            LoadMainMenu();
            return;
        }
        Destroy(gameObject);
    }
    private void Awake()
    {
        Initialize();
    }
    private void LoadSettings()
    {
        gameSettings = Resources.Load<GameSettings>("GameSettings");
        gameSettings.isGamePaused = false;
        gameSettings.isLevelRuning = false;
    }
    private void LoadMainMenu()
    {
        SceneManager.LoadScene(gameSettings.MainMenu, LoadSceneMode.Single);
    }
    private void LogGameState(string message)
    {
        Debug.Log(message);
    }
}