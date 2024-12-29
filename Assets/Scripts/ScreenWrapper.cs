using UnityEngine;

public class ScreenWrapper : MonoBehaviour
{
    private Camera mainCamera;
    private Rigidbody2D rb; // Reference to the Rigidbody2D component

    void Start()
    {
        mainCamera = Camera.main;
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component
    }

    void Update()
    {
        Vector3 screenPosition = mainCamera.WorldToViewportPoint(transform.position);

        // Check for screen wrapping
        if (screenPosition.x < 0)
        {
            screenPosition.x = 1; // Wrap to the right side 
        }
        else if (screenPosition.x > 1)
        {
            screenPosition.x = 0; // Wrap to the left side 
        }

        if (screenPosition.y < 0)
        {
            screenPosition.y = 1; // Wrap to the top 
        }
        else if (screenPosition.y > 1)
        {
            screenPosition.y = 0; // Wrap to the bottom 
        }

        // Update the position using the camera's viewport
        transform.position = mainCamera.ViewportToWorldPoint(screenPosition);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0); // Reset Z Axis
    }
}
