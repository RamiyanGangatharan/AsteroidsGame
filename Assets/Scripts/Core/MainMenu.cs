using System;
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
        ExitButton.onClick.AddListener(ExitGame);
    }
    void PlayGame() { SceneManager.LoadScene(1); }
    void ExitGame() { Environment.Exit(0); }
}