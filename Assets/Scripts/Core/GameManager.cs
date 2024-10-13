using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private readonly int playerLives = 3;
    private readonly int score = 0;
    private readonly bool isPaused = false;

    public GameObject playerShip;
    public GameObject playerShipPrefab;

    public TMP_Text ScoreText;
    public TMP_Text LivesText;

    private void Start()
    {
        Camera.main.backgroundColor = Color.black;

        if (playerShip == null) { playerShip = Instantiate(playerShipPrefab, Vector3.zero, Quaternion.identity); }

        UpdateScore();
        UpdateLives();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && playerShip != null)
        {
            if (playerShip != null) { ResetPlayerShip(); }
            else { Debug.LogError("PlayerShip script is not found on the player ship GameObject!"); }
        }
    }

    public void ResetPlayerShip()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.rotation = Quaternion.identity;
    }

    private void UpdateScore()
    {
        if (ScoreText != null)
        {
            ScoreText.text = "Score: " + score.ToString();
        }
        else
        {
            Debug.LogError("ScoreText is not assigned in the Inspector!");
        }
    }

    private void UpdateLives()
    {
        if (LivesText != null)
        {
            LivesText.text = "Lives: " + playerLives.ToString();
        }
        else
        {
            Debug.LogError("LivesText is not assigned in the Inspector!");
        }
    }
}