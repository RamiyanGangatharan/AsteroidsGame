using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject playerShipPrefab;

    private GameObject playerShip;
    private TMP_Text ScoreText;
    private TMP_Text LivesText;

    private int playerLives = 3;
    private int score = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) { ResetPlayerShip(); }
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