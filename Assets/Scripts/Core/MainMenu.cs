using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManu : MonoBehaviour
{
    public Button PlayButton;
    public Button ExitButton;

    void Start()
    {
        PlayButton.onClick.AddListener(playGame);
        ExitButton.onClick.AddListener(exitApp);
    }

    void playGame() { SceneManager.LoadScene(1); }
    void exitApp() { Application.Quit(); }
}