using UnityEngine;

public class PlayerShooting
{
    public GameObject ProjectilePrefab;

    public PlayerShooting(GameObject projectilePrefab) { this.ProjectilePrefab = projectilePrefab; }

    public void HandleShooting(Transform shipTransform)
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space)) { ShootProjectile(shipTransform); }
    }

    private void ShootProjectile(Transform shipTransform)
    {
        GameObject bullet = Object.Instantiate(ProjectilePrefab, shipTransform.position, shipTransform.rotation);
        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
        Vector2 direction = shipTransform.up;
        bulletRigidbody.linearVelocity = direction * bullet.GetComponent<Projectile>().velocity;
        Object.Destroy(bullet, bullet.GetComponent<Projectile>().projectileHalfLife);
    }
}