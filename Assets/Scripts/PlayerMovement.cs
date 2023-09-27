using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 0f;
    private ActionsEditor playerActions;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerActions = new ActionsEditor();
        playerActions.Player.Enable();
    }

    private void FixedUpdate()
    {
        var inputVector = playerActions.Player.Movement.ReadValue<Vector2>();
        var movement = new Vector3(inputVector.x, 0, inputVector.y);

        if (speed < 250 && playerActions.Player.Acceleration.ReadValue<float>() > 0) speed += 1.5f;
        else if (speed > -20 && playerActions.Player.Break.ReadValue<float>() > 0) speed -= 10f;
        else speed = 1;
        
        if (movement != Vector3.zero) transform.Rotate(0, movement.x, 0);
        rb.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
    }
}