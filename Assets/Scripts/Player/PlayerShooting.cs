using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public ProjectilePool projectilePool; // Reference to the projectile pool
    public Transform launchOffset; // Position from which to launch projectiles
    public float projectileSpeed = 10f; // Speed of the projectile

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (projectilePool == null)
        {
            Debug.LogError("Projectile Pool is not assigned!");
            return;
        }

        GameObject projectile = projectilePool.GetProjectile(); // Get a projectile from the pool

        if (projectile != null)
        {
            // Set the projectile's position and rotation
            projectile.transform.position = launchOffset.position;
            projectile.transform.rotation = transform.rotation;

            // Set the velocity of the projectile using linearVelocity
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.linearVelocity = transform.up * projectileSpeed;
            }
            else
            {
                Debug.LogError("Rigidbody2D component not found on Projectile Prefab!");
            }

            Debug.Log($"Projectile instantiated: {projectile.name}");
        }
        else
        {
            Debug.LogWarning("No projectiles available in the pool!");
        }
    }
}
