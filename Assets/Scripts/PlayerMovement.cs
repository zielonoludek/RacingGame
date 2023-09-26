using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    public int playerNum;

    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private float speed = 10f;
    
    private Rigidbody rb;  
    private float rotationSpeed = 125f;
    private ActionsEditor playerActions;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        //playerActions = new ActionsEditor();
        //playerActions.Player.Enable();

        //playerActions.Player.Movement.performed += Movement;
    }

    private void Update()
    {
        Vector2 movement = playerInput.actions["Movement"].ReadValue<Vector2>();        

        transform.Translate(0, 0, speed * Time.deltaTime);
        transform.Rotate(0, movement.x, 0);
    }

    private void Movement(InputAction.CallbackContext contex)
    {
        Vector2 inputVector = contex.ReadValue<Vector2>();
        rb.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
    }
}
