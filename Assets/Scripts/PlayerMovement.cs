using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 0f;
    private ActionsEditor playerActions;
    private WheelCollider wc;

    private void Awake()
    {
        wc = GetComponent<WheelCollider>();
        playerActions = new ActionsEditor();
        playerActions.Player.Enable();
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
}