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

            LoadSettings();
            LoadMainMenu();
            Debug.Log("Initialized");
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
        gameSettings.isLevelRunning = false;
    }
    private void LoadMainMenu() => SceneManager.LoadScene(gameSettings.MainMenu, LoadSceneMode.Single);
}