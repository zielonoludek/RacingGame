using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 10f;
    private float rotationSpeed = 125f;
    private ActionsEditor playerActions;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        playerActions = new ActionsEditor();
        playerActions.Player.Enable();

        playerActions.Player.Movement.performed += Movement;
    }

    private void Update()
    {
        Vector2 inputVector = playerActions.Player.Movement.ReadValue<Vector2>();
        Vector3 movement = new Vector3(inputVector.x, 0, inputVector.y);
        rb.AddForce(movement * speed, ForceMode.Force);

        if (movement != Vector3.zero)   transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(movement), rotationSpeed * Time.deltaTime);
    }

    private void Movement(InputAction.CallbackContext contex)
    {
        Vector2 inputVector = contex.ReadValue<Vector2>();
        rb.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
    }
}
