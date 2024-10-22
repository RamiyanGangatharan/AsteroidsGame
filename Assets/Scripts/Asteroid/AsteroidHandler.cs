using UnityEngine;

public class AsteroidHandler : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject asteroidPrefab;
    public GameObject playerShip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid")) { HandleCollision(collision, collision.gameObject); }
        if (collision.gameObject.CompareTag("Player")) { HandleCollision(collision, collision.gameObject); }
        if (collision.gameObject.CompareTag("Projectile"))
        {
            SplitAsteroid(collision.gameObject);
            HandleCollision(collision, collision.gameObject);
        }
    }

    private void HandleCollision(Collision2D collision, GameObject obj)
    {
        Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            Vector2 normal = collision.contacts[0].normal;
            Vector2 reflectedVelocity = Vector2.Reflect(rb.linearVelocity, normal);
            rb.linearVelocity = reflectedVelocity;
        }
    }

    private void SplitAsteroid(GameObject asteroid)
    {
        // Assuming you want to split the asteroid into smaller pieces
        Vector3 position = asteroid.transform.position;
        Vector3 scale = asteroid.transform.localScale;

        // Instantiate two smaller asteroids
        GameObject asteroid1 = Instantiate(asteroidPrefab, position + Vector3.left * 0.5f, Quaternion.identity);
        GameObject asteroid2 = Instantiate(asteroidPrefab, position + Vector3.right * 0.5f, Quaternion.identity);

        // Reduce the size of the new asteroids (adjust based on design)
        asteroid1.transform.localScale = scale * 0.5f;
        asteroid2.transform.localScale = scale * 0.5f;

        // Apply random force to scatter the asteroids
        Rigidbody2D rb1 = asteroid1.GetComponent<Rigidbody2D>();
        Rigidbody2D rb2 = asteroid2.GetComponent<Rigidbody2D>();
        rb1.AddForce(Vector2.left * Random.Range(1f, 3f), ForceMode2D.Impulse);
        rb2.AddForce(Vector2.right * Random.Range(1f, 3f), ForceMode2D.Impulse);

        // Destroy the original asteroid
        Destroy(asteroid);
    }
}
