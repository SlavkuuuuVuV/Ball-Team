using UnityEngine;

public class PlayerMove : IMovement
{
    private readonly Rigidbody _rb;
    private readonly float _moveForce;

    public PlayerMove(Rigidbody rb, float moveForce)
    {
        _rb = rb;
        _moveForce = moveForce;
    }

    public void Move(Vector3 direction)
    {
        _rb.AddForce(direction * _moveForce * Time.fixedDeltaTime, ForceMode.Acceleration);
    }
}