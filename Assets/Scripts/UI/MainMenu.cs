using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button startBtn; 
    [SerializeField] private Button exitBtn;
    [SerializeField] private UIManager uiCanvas;

    private void Awake()
    {
        startBtn.onClick.AddListener(StartButton);
        exitBtn.onClick.AddListener(ExitButton);
    }
    private void StartButton()
    {
        uiCanvas.levelPanel.SetActive(true);
        gameObject.SetActive(false);
    }

    private void ExitButton()
    {
       Application.Quit();
       UnityEditor.EditorApplication.isPlaying = false;
    }
}
