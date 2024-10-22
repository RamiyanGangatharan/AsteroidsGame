using UnityEngine;

public class AsteroidHandler : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public GameObject projectilePrefab;
    public GameObject playerShip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Compare by tag instead of direct object reference
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            HandleCollision(collision, collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Projectile"))
        {
            SplitAsteroid(collision.gameObject);
            HandleCollision(collision, collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
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

    // used GPT for the splitting mechanism cuz who actually knows how to split an asteroid bruh
    private void SplitAsteroid(GameObject asteroid)
    {
        Asteroid asteroidComponent = asteroid.GetComponent<Asteroid>();

        if (asteroidComponent != null)
        {
            Vector3 position = asteroid.transform.position;
            Vector3 scale = asteroid.transform.localScale * 0.5f;

            if (scale.x > 0.1f)
            {
                // Instantiate two smaller asteroids
                CreateSplitAsteroid(position + Vector3.left * 0.5f, scale);
                CreateSplitAsteroid(position + Vector3.right * 0.5f, scale);
            }

            // Destroy the original asteroid
            Destroy(asteroid);
        }
    }

    private void CreateSplitAsteroid(Vector3 position, Vector3 scale)
    {
        GameObject newAsteroid = Instantiate(asteroidPrefab, position, Quaternion.identity);
        newAsteroid.transform.localScale = scale;

        // Assign random velocity to new asteroids
        Asteroid asteroidComponent = newAsteroid.GetComponent<Asteroid>();
        if (asteroidComponent != null)
        {
            Vector2 randomVelocity = new Vector2(Random.Range(-2f, 2f), Random.Range(-2f, 2f));
            asteroidComponent.SetVelocity(randomVelocity);
        }
    }
}
