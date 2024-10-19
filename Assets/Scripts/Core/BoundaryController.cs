using UnityEngine;

public class BoundaryController : MonoBehaviour
{
    public GameObject playerShip;

    // Boundary limits for the player's movement
    private float minimum_X;
    private float maximum_X;
    private float minimum_Y;
    private float maximum_Y;

    /**
     * The Start method initializes the boundary limits based on the main camera's viewport and ensures
     * that the player ship has a Rigidbody2D component. If the Rigidbody2D component is missing, it is
     * added, and gravity is disabled (gravityScale set to 0). The camera's viewport boundaries are converted
     * to world space coordinates to define the minimum and maximum X and Y values, which are then used 
     * to clamp the player's position within the visible screen.
     */
    private void Start()
    {
        Camera camera = Camera.main;

        // Set up the Rigidbody2D for the player ship if it doesn't exist
        if (playerShip != null)
        {
            if (playerShip.GetComponent<Rigidbody2D>() == null) { playerShip.AddComponent<Rigidbody2D>().gravityScale = 0; }
        }

        // Calculate the screen boundaries based on the camera's viewport and get the world coordinates of the camera's view
        if (camera != null)
        {
            Vector3 bottomLeft = camera.ViewportToWorldPoint(new Vector3(0, 0, camera.nearClipPlane));
            Vector3 topRight = camera.ViewportToWorldPoint(new Vector3(1, 1, camera.nearClipPlane));
            minimum_X = bottomLeft.x; maximum_X = topRight.x; minimum_Y = bottomLeft.y; maximum_Y = topRight.y;
        }
    }

    /**
     * The Update method ensures that the player's position remains within the calculated screen boundaries.
     * The player's X and Y coordinates are clamped between the minimum and maximum values, effectively
     * keeping the player within the visible area. If the player ship's position exceeds these limits, it is
     * adjusted back within the allowable range.
     */
    private void Update()
    {
        if (playerShip != null)
        {
            Vector3 position = playerShip.transform.position;
            position.x = Mathf.Clamp(position.x, minimum_X, maximum_X);
            position.y = Mathf.Clamp(position.y, minimum_Y, maximum_Y);
            playerShip.transform.position = position;
        }
    }

    /**
     * The OnCollisionEnter2D method handles collisions with the player ship. When the player ship collides 
     * with another object, the method calculates the collision normal and uses it to reflect the player's 
     * velocity, simulating a bounce effect. This reflection is applied to the player ship's Rigidbody2D, 
     * ensuring that the ship changes direction upon impact.
     */
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /**
         * Check if the collided object is the player ship, then get the normal of the collision. 
         * After that reflect the velocity based on the normal and apply the reflected velocity
         */
        if (collision.gameObject == playerShip)
        {
            Rigidbody2D rb = playerShip.GetComponent<Rigidbody2D>();
            Vector2 normal = collision.contacts[0].normal;
            Vector2 reflectedVelocity = Vector2.Reflect(rb.linearVelocity, normal);
            rb.linearVelocity = reflectedVelocity;
        }
    }
}