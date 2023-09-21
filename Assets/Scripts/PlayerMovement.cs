using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        Debug.Log("Jump");
        rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
    }
}
