using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Button MainMenuButton;

    void Start() { MainMenuButton.onClick.AddListener(returnMenu); }
    public void returnMenu() { SceneManager.LoadScene(0); }
}