using UnityEngine;

public class BoundaryController : MonoBehaviour
{
    public GameObject playerShip;

    // Boundary limits
    private float minX;
    private float maxX;
    private float minY;
    private float maxY;

    private void Start()
    {
        // Set up the Rigidbody2D for the player ship if it doesn't exist
        if (playerShip != null && playerShip.GetComponent<Rigidbody2D>() == null)
        {
            playerShip.AddComponent<Rigidbody2D>().gravityScale = 0;
        }

        // Calculate the screen boundaries based on the camera's viewport
        Camera camera = Camera.main;
        if (camera != null)
        {
            // Get the world coordinates of the camera's view
            Vector3 bottomLeft = camera.ViewportToWorldPoint(new Vector3(0, 0, camera.nearClipPlane));
            Vector3 topRight = camera.ViewportToWorldPoint(new Vector3(1, 1, camera.nearClipPlane));

            minX = bottomLeft.x;
            maxX = topRight.x;
            minY = bottomLeft.y;
            maxY = topRight.y;
        }
    }

    private void Update()
    {
        // Clamp the player's position within the specified boundaries
        if (playerShip != null)
        {
            Vector3 position = playerShip.transform.position;
            position.x = Mathf.Clamp(position.x, minX, maxX);
            position.y = Mathf.Clamp(position.y, minY, maxY);
            playerShip.transform.position = position;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object is the player ship
        if (collision.gameObject == playerShip)
        {
            Rigidbody2D rb = playerShip.GetComponent<Rigidbody2D>();
            Vector2 normal = collision.contacts[0].normal; // Get the normal of the collision
            Vector2 reflectedVelocity = Vector2.Reflect(rb.velocity, normal); // Reflect the velocity based on the normal
            rb.velocity = reflectedVelocity; // Apply the reflected velocity
        }
    }
}
