using UnityEngine;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    [SerializeField] private Button L1;
    [SerializeField] private Button L2;
    [SerializeField] private Button L3;
    [SerializeField] private Button exitToMenuBtn;

    [SerializeField] private GameSettings settings;

    private void Awake()
    {
        gameObject.SetActive(false);
        L1.onClick.AddListener(Level1);
        L2.onClick.AddListener(Level2);
        L3.onClick.AddListener(Level3);
        exitToMenuBtn.onClick.AddListener(ExitToMenuButton);
    }
    private void Level1()
    {
        gameObject.SetActive(false);
    }
    private void Level2()
    {
        gameObject.SetActive(false);
    }
    private void Level3()
    {
        gameObject.SetActive(false);
    }
    private void ExitToMenuButton()
    {

    }
}

