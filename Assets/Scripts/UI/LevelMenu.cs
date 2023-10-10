using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    [SerializeField] private Button L1;
    [SerializeField] private Button L2;
    [SerializeField] private Button L3;
    [SerializeField] private Button exitToMenuBtn;
    [SerializeField] private UIManager uiCanvas;

    [SerializeField] private GameSettings gameSettings;

    private void Awake()
    {
        gameObject.SetActive(false);
        L1.onClick.AddListener(Level1);
        L2.onClick.AddListener(Level2);
        L3.onClick.AddListener(Level3);
        exitToMenuBtn.onClick.AddListener(ExitToMenuButton);
    }
    private void Level1() => SceneManager.LoadScene(gameSettings.L1, LoadSceneMode.Single);
    private void Level2() => SceneManager.LoadScene(gameSettings.L2, LoadSceneMode.Single);
    private void Level3() => SceneManager.LoadScene(gameSettings.L3, LoadSceneMode.Single);
    private void ExitToMenuButton() => uiCanvas.mainMenuPanel.SetActive(true);
    private void OnDisable()
    {
        gameObject.SetActive(false);
        gameSettings.isLevelRunning = true;
    }
}

