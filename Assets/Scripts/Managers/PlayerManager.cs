using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private PlayerMovement player1;
    [SerializeField] private PlayerMovement player2;

    private void Awake()
    {
        player1.SetActionMap(false); 
        player2.SetActionMap(true);
    }
}