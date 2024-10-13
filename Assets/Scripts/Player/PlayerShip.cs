using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    public float thrustForce = 10f;
    public float rotationSpeed = 200f;
    public float ReverseThrustForce = 0.01f;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.gravityScale = 0;
    }

    private void Update() { UpdateMovement(); }

    private void UpdateMovement()
    {
        // Check for input
        float rotationInput = 0f;
        if (Input.GetKey(KeyCode.Q)) { rotationInput = -1; }
        if (Input.GetKey(KeyCode.E)) { rotationInput = 1; }

        bool isThrusting = Input.GetKey(KeyCode.W);
        HandleMovement(rotationInput, isThrusting);
    }

    private void HandleMovement(float rotationInput, bool isThrusting)
    {
        if (rotationInput != 0) { Rotate(rotationInput); }

        if (isThrusting) { Thrust(); }
        else { Reverse(); }
    }

    private void Thrust()
    {
        Vector2 thrustDirection = transform.up;
        rigidBody.AddForce(thrustDirection * thrustForce);
    }

    private void Reverse()
    {
        Vector2 thrustDirection = Vector2.down;
        rigidBody.AddForce(thrustDirection * ReverseThrustForce);
    }

    private void Rotate(float direction) { transform.Rotate(0, 0, direction * rotationSpeed * Time.deltaTime); }
}