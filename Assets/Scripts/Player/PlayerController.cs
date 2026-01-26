using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveForce = 100;

    private IMovement _movement;
    private IPlayerInput _playerInput;


    private void Start()
    {
        var rb = GetComponent<Rigidbody>();

        _playerInput = new PlayerInput();
        _movement = new PlayerMove(rb, moveForce);
    }


    private void FixedUpdate()
    {
        Vector3 direction = _playerInput.GetDirection();

        _movement.Move(direction);
    }
}