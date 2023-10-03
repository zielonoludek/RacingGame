using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    /*  aditional not working feature feature
        will debug and fix it later
    
    private GameObject Player;
    private Vector3 position = new Vector3(0, 25f, -15f);
    private float oldRotation;
    private float rotation;

    private void Awake() 
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        transform.position = position + Player.transform.position;
        oldRotation = Player.transform.rotation.y;
        rotation = oldRotation;
    }

    private void Update() => rotation = Player.transform.rotation.y;
    
    private void LateUpdate()
    {
        if (rotation != oldRotation)
        {
            transform.Rotate(0, rotation, 0);
            oldRotation = rotation;
        }

    }

    private void FixedUpdate()
    {
        transform.position = position + Player.transform.position;
    }
    */
}

