using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame

    void LateUpdate() // Best for follow cameras and tasks that change position (last known state)
    {
        transform.position = player.transform.position + offset;
    }
}
