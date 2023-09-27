using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    private PlayerInput playerInput;
    [SerializeField] private float speed = 10f;

    private void Awake() => playerInput = GetComponent<PlayerInput>();

    private void Update()
    {
        Vector2 movement = playerInput.actions["Movement"].ReadValue<Vector2>();

        transform.Translate(0, 0, speed * Time.deltaTime);
        transform.Rotate(0, movement.x, 0);
    }
}
