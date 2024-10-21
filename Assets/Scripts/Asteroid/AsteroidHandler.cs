using System.Xml.Serialization;
using UnityEngine;

public class AsteroidHandler : MonoBehaviour
{
    public GameObject Projectile;
    public GameObject Asteroid;
    public GameObject PlayerShip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Asteroid --> Asteroid
        if (collision.gameObject == Asteroid)
        {

        }

        // Asteroid --> Projectile || Projectile --> Asteroid
        if (collision.gameObject == Projectile)
        {
            SplitAsteroid();
        }

        // Asteroid --> Player || Player --> Asteroid
        if (collision.gameObject == PlayerShip)
        {

        }
    }

    private void SplitAsteroid()
    {

    }
}