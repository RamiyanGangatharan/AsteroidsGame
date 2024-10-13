using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManu : MonoBehaviour
{
    public Button PlayButton;
    public Button ExitButton;

    // Start is called before the first frame update
    void Start()
    {
        PlayButton.onClick.AddListener(playGame);
        ExitButton.onClick.AddListener(exitApp);
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void playGame()
    {
        SceneManager.LoadScene(1);
    }

    void exitApp()
    {
        Application.Quit();
    }
}
