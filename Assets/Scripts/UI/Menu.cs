using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private Button resumeBtn; 
    [SerializeField] private Button exitToMenuBtn;
    [SerializeField] private Button quitBtn;

    private void Awake()
    {
        gameObject.SetActive(false);
        resumeBtn.onClick.AddListener(ResumeButton);
        exitToMenuBtn.onClick.AddListener(ExitToMenuButton);
        quitBtn.onClick.AddListener(QuitButton);
    }
    private void ResumeButton()
    {
        gameObject.SetActive(false);
    }
    private void ExitToMenuButton()
    {
       
    }
    private void QuitButton()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
