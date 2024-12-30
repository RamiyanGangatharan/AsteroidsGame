using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private bool isPaused = false;
    private bool gameOver = false;

    public int lives = 3;

    // Start is called once before the first execution of Update
    void Start() { Camera.main.backgroundColor = Color.black; }

    // Main Game Loop
    void Update()
    {
        HandleInput();
        CheckGameOver();
    }

    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused) { resumeGame(); }
            else { pauseGame(); }
        }
    }

    private void CheckGameOver()
    {
        if (lives == 0) { gameOver = true; }
        if (gameOver) { SceneManager.LoadScene(3); } // Load Game Over Screen
    }

    public void resumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        if (SceneManager.GetSceneByBuildIndex(2).isLoaded) { SceneManager.UnloadSceneAsync(2); }
    }

    public void pauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        if (!SceneManager.GetSceneByBuildIndex(2).isLoaded) { SceneManager.LoadScene(2, LoadSceneMode.Additive); }
    }

    // Call this function to decrement lives
    public void LoseLife() { lives--; }
}
