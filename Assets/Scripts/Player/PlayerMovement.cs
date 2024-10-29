using UnityEngine;

public class PlayerMovement
{
    private Rigidbody2D rigidBody;
    private float thrustForce = 1f;
    private float reverseThrustForce = 0.01f;
    private float rotationSpeed;

    public PlayerMovement(Rigidbody2D rb, float rotationSpeed)
    {
        this.rigidBody = rb;
        this.rotationSpeed = rotationSpeed;
    }

    public void HandleMovement()
    {
        HandleRotation();
        HandleThrust();
    }

    private void HandleRotation()
    {
        float rotationInput = 0f;

        if (Input.GetKey(KeyCode.Q)) rotationInput = -1f;
        else if (Input.GetKey(KeyCode.E)) rotationInput = 1f;

        if (rotationInput != 0f) { rigidBody.transform.Rotate(0f, 0f, rotationInput * rotationSpeed * Time.deltaTime); }
    }

    private void HandleThrust()
    {
        Vector2 thrustDirection = Input.GetKey(KeyCode.W) ? rigidBody.transform.up : Vector2.down;
        float forceToApply = Input.GetKey(KeyCode.W) ? thrustForce : reverseThrustForce;
        rigidBody.AddForce(thrustDirection * forceToApply);
    }
}