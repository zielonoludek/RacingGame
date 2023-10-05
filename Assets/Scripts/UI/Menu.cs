using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{
    private Button startBtn;

    private void Awake()
    {
        startBtn.onClick.AddListener(StartButton);
    }

    private void Update()
    {

    }

    private void StartButton()
    {
        gameObject.SetActive(true);
    }
}
