using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
    [SerializeField] GameSettings settings;
    private ActionsEditor playerActions;

    private float speed = 0f;
    private float minSpeed = -20f;
    private float maxSpeed = 100;
    private float powerUpSpeed = 150;

    private float powerUpTime = 1;
    private float elapsed = 0;
    private float reversingModifier = 2;
    private float accelerationOffset = 1.5f;
    private bool secondPlayer;

    private void Awake()
    {
        playerActions = new ActionsEditor();
        playerActions.Player.Enable();
        elapsed = Time.time;
    }
    private void Start() => secondPlayer = playerActions.Player1.enabled;
    private void FixedUpdate()
    {
        var inputVector = new Vector2();
        if (secondPlayer) inputVector = playerActions.Player1.Movement.ReadValue<Vector2>();
        else inputVector = playerActions.Player.Movement.ReadValue<Vector2>();

        var movement = new Vector3(inputVector.x, 0, inputVector.y);

        if (settings.isLevelRunning && !settings.isGamePaused)
        {
            if (speed < maxSpeed && playerActions.Player.Acceleration.ReadValue<float>() > 0) speed += accelerationOffset;
            else if (speed < maxSpeed && playerActions.Player1.Acceleration.ReadValue<float>() > 0) speed += accelerationOffset;
            
            if (speed > minSpeed && playerActions.Player.Reversing.ReadValue<float>() > 0) speed -= reversingModifier;
            else if (speed > minSpeed && playerActions.Player1.Reversing.ReadValue<float>() > 0) speed -= reversingModifier;

            if (movement != Vector3.zero) transform.Rotate(0, movement.x, 0);
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
    }
    private void Update()
    {
       if (Time.time - elapsed > powerUpTime && speed == powerUpSpeed)
        {
            speed = maxSpeed;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("barrier"))
        {
            Debug.Log("Car's hitting the barrier!!!");
            speed = -speed / reversingModifier;
        }

        if (collision.gameObject.CompareTag("PowerUp"))
        {
            Debug.Log("Power up!!!");
            speed = powerUpSpeed;
            elapsed = Time.time;
        }
    }
    public bool SetActionMap(bool secondPlayer)
    {
        if (secondPlayer)
        { 
            playerActions.Player1.Enable();
            playerActions.Player.Disable();
        }
        return secondPlayer;
    }
}