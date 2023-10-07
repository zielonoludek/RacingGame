using System.Xml;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 0f;
    private ActionsEditor playerActions;
    private float powerUpTime = 1;
    private float elapsed = 0; 

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

        if (speed < 100 && playerActions.Player.Acceleration.ReadValue<float>() > 0) speed += 1.5f;
        if (speed > -20 && playerActions.Player.Reversing.ReadValue<float>() > 0) speed -= 2;

        if (movement != Vector3.zero) transform.Rotate(0, movement.x, 0);
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void Update()
    {
       if (Time.time - elapsed > powerUpTime && speed == 150)
        {
            speed = 100;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("barrier"))
        {
            Debug.Log("Car's hitting the barrier!!!");
            speed = -speed / 2;
        }

        if (collision.gameObject.CompareTag("PowerUp"))
        {
            Debug.Log("Power up!!!");
            speed = 150;
            elapsed = Time.time;
        }
    }
}