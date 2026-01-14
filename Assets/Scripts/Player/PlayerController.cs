using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;
    
    [SerializeField] private float moveForce;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        
        _rb.AddForce(direction * moveForce * Time.fixedDeltaTime, ForceMode.Acceleration);
    }
}
