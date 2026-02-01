using UnityEngine;

public class PlayerInput : IPlayerInput
{
    public Vector3 GetDirection()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        return new Vector3(horizontal, 0, vertical);
    }
}
