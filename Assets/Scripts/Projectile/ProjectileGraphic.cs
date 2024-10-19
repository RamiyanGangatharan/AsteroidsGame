using UnityEngine;

public class ProjectileGraphic : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private readonly float scaleFactor = 0.05f;

    float WIDTH = 0.1f;
    int VERTICIES = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();

        // Vectors for the projectile (A straight line)
        Vector3 startPoint = new Vector3(0, 1 * scaleFactor, 0);
        Vector3 endPoint = new Vector3(0, 5 * scaleFactor, 0);

        if (lineRenderer == null) { lineRenderer = gameObject.AddComponent<LineRenderer>(); }

        lineRenderer.useWorldSpace = false;                               // Use local space for the line positions.
        lineRenderer.material = new Material(Shader.Find("Unlit/Color")); // Set the material to a color shader.
        lineRenderer.startColor = Color.white;                            // Set the start color of the line to white.
        lineRenderer.endColor = new Color(0, 1, 1, 0);                    // Set the end color to fade to transparent.
        lineRenderer.startWidth = WIDTH;                                  // Set the starting width of the line.
        lineRenderer.endWidth = WIDTH * 0.5f;                             // Set the ending width of the line then taper it.
        lineRenderer.positionCount = VERTICIES;                           // Set the number of vertices in the LineRenderer.

        // Define the positions of the projectile graphic in local space.
        lineRenderer.SetPosition(0, startPoint);
        lineRenderer.SetPosition(1, endPoint);
    }
}