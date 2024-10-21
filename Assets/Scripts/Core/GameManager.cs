using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerShipPrefab;
    private TMP_Text ScoreText;
    private TMP_Text LivesText;
    private GameObject playerShip;

    private int playerLives = 3;
    private int score = 0;

    private void Start() 
    { 
        Camera.main.backgroundColor = Color.black;

        if (playerShip == null) { playerShip = Instantiate(playerShipPrefab, Vector3.zero, Quaternion.identity); }

        UpdateScoreUI();
        UpdateLivesUI();
    }

    private void UpdateScoreUI()
    {
        if (ScoreText != null) { ScoreText.text = "Score: " + score.ToString(); }
        else { Debug.LogError("ScoreText is not assigned in the Inspector!"); }
    }

    private void UpdateLivesUI()
    {
        if (LivesText != null) { LivesText.text = "Lives: " + playerLives.ToString(); }
        else { Debug.LogError("LivesText is not assigned in the Inspector!"); }
    }
}