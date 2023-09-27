using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    public Rigidbody rig;
    public float acceleration;
    public float turnSpeed;
    public Transform carModel;
    public float groundCheckRate;

    private Vector3 startModelOffset;
    private float curYRot;
    private float turnInput;
    private  bool accelerateInput;

    // Start is called before the first frame update
    void Start()
    {
        startModelOffset = carModel.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        curYRot += turnInput * turnSpeed * Time.deltaTime;

        carModel.position = transform.position+ startModelOffset;
        carModel.eulerAngles = new Vector3(0,curYRot,0);
    }

    //FixedUpdate runs 60 times per second consistently
    private void FixedUpdate()
    {
        if(accelerateInput)
        {
            rig.AddForce(carModel.forward * acceleration, ForceMode.Acceleration);
        }
    }

    public void OnAccelerateInput(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            accelerateInput = true;
        else
            accelerateInput = false;
    }
    
    public void OnTurnInput(InputAction.CallbackContext context) => turnInput = context.ReadValue<float>();

}
