using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform launchOffset;
    public float projectileSpeed = 10f;

    void Update() { if (Input.GetKeyDown(KeyCode.Space)) { Shoot(); } }

    void Shoot()
    {
        if (projectilePrefab == null)
        {
            Debug.LogError("Projectile Prefab is not assigned!");
            return;
        }

        Debug.Log($"Instantiating projectile: {projectilePrefab.name}");

        GameObject projectile = Instantiate(projectilePrefab, launchOffset.position, transform.rotation);
        if (projectile != null)
        {
            Debug.Log($"Projectile instantiated: {projectile.name}");
        }

        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = transform.up * projectileSpeed;
        }
        else
        {
            Debug.LogError("Rigidbody2D component not found on Projectile Prefab!");
        }
    }
}
