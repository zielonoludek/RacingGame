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

    private void Awake()
    {
        playerActions = new ActionsEditor();
        playerActions.Player.Enable();
        elapsed = Time.time;
    }
    private void FixedUpdate()
    {
        var inputVector = playerActions.Player.Movement.ReadValue<Vector2>();
        var movement = new Vector3(inputVector.x, 0, inputVector.y);

        if (settings.isLevelRunning && !settings.isGamePaused)
        {
            if (speed < maxSpeed && playerActions.Player.Acceleration.ReadValue<float>() > 0) speed += accelerationOffset;
            if (speed > minSpeed && playerActions.Player.Reversing.ReadValue<float>() > 0) speed -= reversingModifier;

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
}