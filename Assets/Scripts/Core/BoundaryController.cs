using UnityEngine;

public class BoundaryController : MonoBehaviour
{
    public GameObject playerShip;
    public float minimum_X;
    public float maximum_X;
    public float minimum_Y;
    public float maximum_Y;

    private void Start() { InitializeBoundary(); }

    private void Update() { ClampPlayerPosition(); }

    private void OnCollisionEnter2D(Collision2D collision) { HandleCollision(collision); }

    private void InitializeBoundary()
    {
        Camera camera = Camera.main;

        if (playerShip != null)
        {
            if (playerShip.GetComponent<Rigidbody2D>() == null) { playerShip.AddComponent<Rigidbody2D>().gravityScale = 0; }
        }

        if (camera != null)
        {
            Vector3 bottomLeft = camera.ViewportToWorldPoint(new Vector3(0, 0, camera.nearClipPlane));
            Vector3 topRight = camera.ViewportToWorldPoint(new Vector3(1, 1, camera.nearClipPlane));
            minimum_X = bottomLeft.x;
            maximum_X = topRight.x;
            minimum_Y = bottomLeft.y;
            maximum_Y = topRight.y;
        }
    }

    private void ClampPlayerPosition()
    {
        if (playerShip != null)
        {
            Vector3 position = playerShip.transform.position;
            position.x = Mathf.Clamp(position.x, minimum_X, maximum_X);
            position.y = Mathf.Clamp(position.y, minimum_Y, maximum_Y);
            playerShip.transform.position = position;
        }
    }

    private void HandleCollision(Collision2D collision)
    {
        if (collision.gameObject == playerShip)
        {
            Rigidbody2D rb = playerShip.GetComponent<Rigidbody2D>();
            Vector2 normal = collision.contacts[0].normal;
            Vector2 reflectedVelocity = Vector2.Reflect(rb.linearVelocity, normal);
            rb.linearVelocity = reflectedVelocity;
        }
    }
}