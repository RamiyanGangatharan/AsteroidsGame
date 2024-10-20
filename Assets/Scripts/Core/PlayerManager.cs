using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject playerShipPrefab;
    public TMP_Text ScoreText;
    public TMP_Text LivesText;

    private GameObject playerShip;
    private int playerLives = 3;
    private int score = 0;

    private void Start() { InitializeGame(); }

    private void InitializeGame()
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

    public void ResetPlayerShip()
    {
        if (playerShip != null)
        {
            Rigidbody2D rigidBody = playerShip.GetComponent<Rigidbody2D>();
            Vector3 centerScreen = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, Camera.main.nearClipPlane));
            playerShip.transform.position = new Vector3(centerScreen.x, centerScreen.y, 0);
            playerShip.transform.rotation = Quaternion.identity;

            if (rigidBody != null)
            {
                rigidBody.linearVelocity = Vector2.zero;
                rigidBody.angularVelocity = 0f;
            }
        }
        else { Debug.LogError("PlayerShip GameObject is not assigned!"); }
    }
}