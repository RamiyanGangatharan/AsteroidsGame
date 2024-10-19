using UnityEngine;

public class ShipGraphic : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private readonly float scaleFactor = 0.5f;

    float WIDTH = 0.05f;
    int VERTICES = 4;


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

        // Vectors for the player (Triangle)
        Vector3 top = new Vector3(0, 1 * scaleFactor, 0);
        Vector3 bottomLeft = new Vector3(-scaleFactor * scaleFactor, -1 * scaleFactor, 0);
        Vector3 bottomRight = new Vector3(scaleFactor * scaleFactor, -1 * scaleFactor, 0);
        Vector3 close = new Vector3(0, 1 * scaleFactor, 0);

        if (lineRenderer == null) { lineRenderer = gameObject.AddComponent<LineRenderer>(); }

        lineRenderer.useWorldSpace = false;                               // Use local space for the line positions.
        lineRenderer.material = new Material(Shader.Find("Unlit/Color")); // Set the material to a color shader.
        lineRenderer.startColor = Color.white;                            // Set the start color of the line to white.
        lineRenderer.endColor = Color.white;                              // Set the end color of the line to white.
        lineRenderer.startWidth = WIDTH;                                  // Set the starting width of the line.
        lineRenderer.endWidth = WIDTH;                                    // Set the ending width of the line.
        lineRenderer.positionCount = VERTICES;                            // Set the number of vertices in the LineRenderer.

        // Define the positions of the ship graphic in local space.
        lineRenderer.SetPosition(0, top);                           
        lineRenderer.SetPosition(1, bottomLeft); 
        lineRenderer.SetPosition(2, bottomRight);  
        lineRenderer.SetPosition(3, close);                           
    }
}