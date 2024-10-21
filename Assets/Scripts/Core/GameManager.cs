using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject playerShipPrefab;
    private TMP_Text ScoreText;
    private TMP_Text LivesText;
    private GameObject playerShip;

    private int playerLives = 3;
    private int score = 0;

    private void Start() 
    { 
        Camera.main.backgroundColor = Color.black;

        if (playerShip == null && playerShipPrefab != null)
        {
            playerShip = Instantiate(playerShipPrefab, Vector3.zero, Quaternion.identity);
        }

        //UpdateScoreUI();
        //UpdateLivesUI();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) { ResetPlayerShip(); }
    }

    // UNCOMMENT THIS WHEN WE IMPLEMENT SCORE AND LIVES GUI
    //private void UpdateScoreUI()
    //{
    //    if (ScoreText != null) { ScoreText.text = "Score: " + score.ToString(); }
    //    else { Debug.LogError("ScoreText is not assigned in the Inspector!"); }
    //}

    //private void UpdateLivesUI()
    //{
    //    if (LivesText != null) { LivesText.text = "Lives: " + playerLives.ToString(); }
    //    else { Debug.LogError("LivesText is not assigned in the Inspector!"); }
    //}

    public void ResetPlayerShip()
    {
        if (playerShip == null) return; // Add this line

        Rigidbody2D rigidBody = playerShip.GetComponent<Rigidbody2D>();
        Vector3 centerScreen = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, Camera.main.nearClipPlane));
        playerShip.transform.position = new Vector3(centerScreen.x, centerScreen.y, 0);
        playerShip.transform.rotation = Quaternion.identity;

        if (rigidBody != null)
        {
            rigidBody.linearVelocity = Vector2.zero;  // `linearVelocity` should be `velocity`
            rigidBody.angularVelocity = 0f;
        }
    }
}