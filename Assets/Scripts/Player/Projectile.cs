using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifetime = 3f; // Lifetime in seconds

    void Start()
    {
        //Destroy(gameObject, lifetime); // Destroy after lifetime expires
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Destroy the projectile when it hits something
        Destroy(gameObject);
    }
}
