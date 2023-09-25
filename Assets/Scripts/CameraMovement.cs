using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private GameObject Player;
    private Vector3 position = new Vector3(0, 3.57f, -9.5f);
    
    private void Awake() 
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        transform.position = position + Player.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = position + Player.transform.position;
    }
}
