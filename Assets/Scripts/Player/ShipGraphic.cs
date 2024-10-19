using UnityEngine;

public class ShipGraphic : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private readonly float scaleFactor = 0.5f;

    float WIDTH = 0.05f;
    int VERTICIES = 4;

    /**
     * The Start method is called before the first frame update. It initializes the LineRenderer component, which is
     * responsible for rendering the visual representation of the ship. If a LineRenderer is not already attached to 
     * the GameObject, it adds a new one. The LineRenderer is configured to not use world space for its positions, 
     * meaning the positions are relative to the GameObject itself. The material used for the line is set to an unlit 
     * color shader with white for both the start and end colors, ensuring a consistent appearance. The start and end 
     * widths of the line are defined, creating a uniform thickness. The number of positions (or points) for the 
     * LineRenderer is set to 4, allowing for the creation of a closed shape that resembles a ship. The positions are 
     * defined in local space to create the vertices of the ship's shape: the top point, bottom left point, bottom right
     * point, and finally closing the shape by returning to the top point.
     */
    private void Start()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();

        if (lineRenderer == null) { lineRenderer = gameObject.AddComponent<LineRenderer>(); }

        lineRenderer.useWorldSpace = false;                               // Use local space for the line positions.
        lineRenderer.material = new Material(Shader.Find("Unlit/Color")); // Set the material to a color shader.
        lineRenderer.startColor = Color.white;                            // Set the start color of the line to white.
        lineRenderer.endColor = Color.white;                              // Set the end color of the line to white.
        lineRenderer.startWidth = WIDTH;                                  // Set the starting width of the line.
        lineRenderer.endWidth = WIDTH;                                    // Set the ending width of the line.
        lineRenderer.positionCount = VERTICIES;                           // Set the number of vertices in the LineRenderer.

        // Define the positions of the ship graphic in local space.
        lineRenderer.SetPosition(0, new Vector3(0, 1 * scaleFactor, 0));                           // Top point of the ship.
        lineRenderer.SetPosition(1, new Vector3(-scaleFactor * scaleFactor, -1 * scaleFactor, 0)); // Bottom left point.
        lineRenderer.SetPosition(2, new Vector3(scaleFactor * scaleFactor, -1 * scaleFactor, 0));  // Bottom right point.
        lineRenderer.SetPosition(3, new Vector3(0, 1 * scaleFactor, 0));                           // Close shape at top.
    }
}