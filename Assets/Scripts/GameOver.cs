using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Button mainMenuButton;
    PauseMenu pauseMenu = new PauseMenu();

    void Start() { mainMenuButton.onClick.AddListener(MainMenu); }
    void MainMenu() { pauseMenu.returnMenu(); }
}