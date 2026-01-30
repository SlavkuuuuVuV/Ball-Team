using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneMap : MonoBehaviour
{
    [SerializeField] private Button startButton;
    private void Start()
    {
        startButton.onClick.AddListener(LoadSceneLevel1);
    }

    private void LoadSceneLevel1()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
