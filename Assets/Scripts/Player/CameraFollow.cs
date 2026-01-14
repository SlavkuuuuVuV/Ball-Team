using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Vector3 _cameraOffset;
    void Start()
    {
        _cameraOffset = transform.position - playerTransform.position;
    }
    
    void Update()
    {
        transform.position =  playerTransform.position + _cameraOffset;
    }
}
