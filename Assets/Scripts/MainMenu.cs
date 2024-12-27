using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button PlayButton;
    public Button ExitButton;

    void Start()
    {
        PlayButton.onClick.AddListener(PlayGame);
    }
    void Update()
    {
        
    }

    private void PlayGame()
    {
        Debug.Log("Play Button has been clicked.");
        SceneManager.LoadScene(1);
    }
}