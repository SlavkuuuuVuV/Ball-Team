using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    public int lives = 3;                   
    [SerializeField] private Image[] _life;  
 
    private Vector3 _checkpointPosition;      
    private bool _isFalling = false;      
    public GameObject gameOverUI;

    private void Awake()
    {
        _checkpointPosition = transform.position;
    }

    private void Update()
    {
        if (transform.position.y < -9f && !_isFalling)
        {
            _isFalling = true;
            TakeDamage();
        }
    }

    private void TakeDamage()
    {
        if (lives <= 0)
            return;
        
        lives--;
        
        _life[lives].enabled = false;
        
        if (lives == 0)
        {
            gameOverUI.SetActive(true);
            Time.timeScale = 0;
            return;
        }
        
        transform.position = _checkpointPosition;

        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        _isFalling = false;
    }
    
    public void SetCheckpoint(Vector3 newCheckpoint)
    {
        _checkpointPosition = newCheckpoint;
    }
}
