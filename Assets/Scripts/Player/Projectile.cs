using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifetime = 3f; // Lifetime in seconds
    private ProjectilePool projectilePool; // Reference to the projectile pool

    void Start()
    {
        // Find the projectile pool component in the scene
        projectilePool = Object.FindFirstObjectByType<ProjectilePool>();
        if (projectilePool != null)
        {
            // Destroy this projectile after its lifetime and return it to the pool
            Invoke("ReturnToPool", lifetime);
        }
        else
        {
            Debug.LogError("No ProjectilePool found in the scene.");
        }
    }

    void ReturnToPool()
    {
        if (projectilePool != null)
        {
            projectilePool.ReturnProjectile(gameObject); // Return the projectile to the pool
        }
        else
        {
            Debug.LogError("ProjectilePool reference is lost. Cannot return to pool.");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        ReturnToPool(); // Optionally return to pool on collision
    }
}
