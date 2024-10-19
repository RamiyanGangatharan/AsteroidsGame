using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float velocity = 15f; 
    public float projectileHalfLife = 1.0f; 

    void Start() { rigidBody = GetComponent<Rigidbody2D>(); }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            Asteroid asteroid = collision.gameObject.GetComponent<Asteroid>();
            if (asteroid != null)
            {
                Destroy(asteroid);
                asteroid.SpawnAsteroid();
            }
        }
    }
}