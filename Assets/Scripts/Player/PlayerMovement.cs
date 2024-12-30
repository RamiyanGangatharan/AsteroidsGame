using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float thrustForce = 5f; // Force applied for thrust
    public float rotationSpeed = 200f; // Speed of rotation
    public float maxSpeed = 10f; // Maximum speed

    private Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Thrust forward
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(transform.up * thrustForce);
        }

        // Thrust backward
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(-transform.up * thrustForce);
        }

        // Rotate left (counter-clockwise)
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddTorque(rotationSpeed * Time.deltaTime);
        }

        // Rotate right (clockwise)
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddTorque(-rotationSpeed * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {
        // Clamp the velocity to the maximum speed
        if (rigidbody.linearVelocity.magnitude > maxSpeed)
        {
            rigidbody.linearVelocity = rigidbody.linearVelocity.normalized * maxSpeed;
        }
    }
}