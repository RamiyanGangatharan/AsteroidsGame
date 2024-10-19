using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public GameObject ProjectilePrefab;

    public float thrustForce = 1f;
    public float rotationSpeed = 200f;
    public float reverseThrustForce = 0.01f;

    // Initializes the rigidbody and sets gravity to 0 as it is in space
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.gravityScale = 0; // Disable gravity
    }

    // Detects and processes player controls for movement and shooting
    private void Update()
    {
        HandleRotation();
        HandleThrust();
        HandleShooting();
    }

    // Handles ship rotation based on player input
    private void HandleRotation()
    {
        float rotationInput = 0f;

        if (Input.GetKey(KeyCode.Q)) { rotationInput = -1f; }
        else if (Input.GetKey(KeyCode.E)) { rotationInput = 1f; }

        if (rotationInput != 0f)
        {
            transform.Rotate(0f, 0f, rotationInput * rotationSpeed * Time.deltaTime);
        }
    }

    // Handles thrust based on player input
    private void HandleThrust()
    {
        Vector2 thrustDirection = Input.GetKey(KeyCode.W) ? transform.up : Vector2.down;
        float forceToApply = Input.GetKey(KeyCode.W) ? thrustForce : reverseThrustForce;
        rigidBody.AddForce(thrustDirection * forceToApply);
    }

    // Handles shooting projectiles from the ship
    private void HandleShooting()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(ProjectilePrefab, transform.position, transform.rotation);
            Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
            Vector2 direction = transform.up;
            bulletRigidbody.linearVelocity = direction * bullet.GetComponent<Projectile>().velocity;
            Destroy(bullet, bullet.GetComponent<Projectile>().projectileHalfLife);
        }
    }
}