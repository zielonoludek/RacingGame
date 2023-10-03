using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private Button mainMenu;
    [SerializeField] private Button start;

    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject menuPanel;

    void Start()
    {
        mainMenuPanel.SetActive(true);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuPanel.SetActive(true);
        }
    }
}
