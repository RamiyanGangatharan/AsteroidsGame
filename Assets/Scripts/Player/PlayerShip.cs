using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    public float thrustForce = 10f;
    public float rotationSpeed = 200f;
    public float ReverseThrustForce = 0.01f;

    // Sets the rigidbody and sets gravity to 0 as it is in space
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.gravityScale = 0;
    }

    // This detects and asserts the controls onto the player object
    private void Update() { UpdateMovement(); }

    /**
     * This function handles the player's input for ship movement, configuring keybinds for rotation 
     * and thrust. When the player presses the thrust key (W), the ship moves forward in the direction 
     * it is facing. If the thrust key is not pressed, the ship moves backward, simulating reverse 
     * thrust. The ship also rotates based on player input: pressing 'Q' rotates the ship
     * counterclockwise, while pressing 'E' rotates it clockwise. Both rotation and thrust are applied 
     * to the ship's Rigidbody component. 
     * 
     * If the player presses 'Q', the ship rotates counterclockwise (negative rotation), and pressing 
     * 'E' causes clockwise rotation (positive rotation). No input results in no rotation. Rotation is
     * applied around the Z-axis for 2D rotation using the transform's Rotate method. The rotation 
     * speed is controlled by the 'rotationSpeed' variable and scaled by Time.deltaTime to ensure 
     * consistency across different frame rates.
     * 
     * When the player holds the 'W' key, forward thrust is applied in the direction the ship is facing
     * (transform.up). If the 'W' key is not pressed, reverse thrust is applied, simulating deceleration
     * or backward movement. The direction of the force is dynamically determined based on the player's
     * input, either forward (transform.up) or backward (Vector2.down). The corresponding force—either
     * thrustForce for forward movement or ReverseThrustForce for reverse movement—is applied to the 
     * ship's Rigidbody. This is accomplished using Rigidbody.AddForce, which takes into account both 
     * the direction of the thrust and the magnitude of the applied force.
     */
    private void UpdateMovement()
    {
        float rotationInput = 0f;
        float counterClockwise = -1f;
        float clockwise = 1f;

        if (Input.GetKey(KeyCode.Q)) { rotationInput = counterClockwise; }

        else if (Input.GetKey(KeyCode.E)) { rotationInput = clockwise; }

        if (rotationInput != 0f)
        {
            transform.Rotate(0f, 0f, rotationInput * rotationSpeed * Time.deltaTime);
        }

        Vector2 thrustDirection = Input.GetKey(KeyCode.W) ? transform.up : Vector2.down;
        float forceToApply = Input.GetKey(KeyCode.W) ? thrustForce : ReverseThrustForce;

        rigidBody.AddForce(thrustDirection * forceToApply);
    }
}