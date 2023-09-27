using System;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    private PlayerInput playerInput;
    [SerializeField] private float speed = 0f;
    

    private void Awake() => playerInput = GetComponent<PlayerInput>();

    private void FixedUpdate()
    {
        Vector2 movement = playerInput.actions["Movement"].ReadValue<Vector2>();

        ChangeVelocity();

        transform.Translate(0, 0, speed * Time.deltaTime);
        transform.Rotate(0, movement.x, 0);
    }

    private void ChangeVelocity()
    {
        if (playerInput.actions["Acceleration"].IsPressed() && speed < 250) speed += 1.5f;
        if (playerInput.actions["Break"].IsPressed() && speed > -20) speed -= 10f;
    }
}