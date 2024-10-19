using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private readonly int playerLives = 3;
    private readonly int score = 0;

    public GameObject playerShip;
    public GameObject playerShipPrefab;
    public TMP_Text ScoreText;
    public TMP_Text LivesText;

    Vector3 centerScreen = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, Camera.main.nearClipPlane));

    /**
     * The Start method initializes the game scene and sets up key game elements. It configures the camera's 
     * background color to black, and if the playerShip GameObject does not exist, it instantiates one at 
     * the origin (0,0) with no rotation. It also initializes the UI by updating the score and lives text 
     * on the screen. If ScoreText or LivesText is not assigned in the Unity Inspector, an error is logged 
     * to help identify the issue. This ensures that the game is ready to start, with the player ship in place 
     * and the HUD (score and lives) set correctly.
     */
    private void Start()
    {
        Camera.main.backgroundColor = Color.black;

        if (playerShip == null) { playerShip = Instantiate(playerShipPrefab, Vector3.zero, Quaternion.identity); }

        if (ScoreText != null) { ScoreText.text = "Score: " + score.ToString(); }
        else { Debug.LogError("ScoreText is not assigned in the Inspector!"); }

        if (LivesText != null) { LivesText.text = "Lives: " + playerLives.ToString(); }
        else { Debug.LogError("LivesText is not assigned in the Inspector!"); }
    }

    /**
     * The Update method is called every frame and listens for player input to reset the player's ship 
     * position. When the 'R' key is pressed, it moves the player ship to the center of the screen, resets 
     * its rotation to the default orientation, and sets its velocity to zero (stopping any movement). This 
     * allows the player to reset their ship if necessary during gameplay. If the playerShip GameObject is 
     * not assigned, an error message is logged to ensure debugging is easier.
     */
    private void Update()
    {
        Rigidbody2D rigidBody = playerShip.GetComponent<Rigidbody2D>();

        if (Input.GetKeyDown(KeyCode.R) && playerShip != null)
        {
            playerShip.transform.position = new Vector3(centerScreen.x, centerScreen.y, 0);
            playerShip.transform.rotation = Quaternion.identity;

            if (rigidBody != null)
            {
                rigidBody.linearVelocity = Vector2.zero;
                rigidBody.angularVelocity = 0f;
            }
        }
        else if (Input.GetKeyDown(KeyCode.R)) { Debug.LogError("PlayerShip GameObject is not assigned!"); }
    }
}