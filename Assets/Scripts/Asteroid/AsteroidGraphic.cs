using UnityEngine;

public class AsteroidGraphic : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private readonly float scaleFactor = 0.5f;

    float WIDTH = 0.05f;
    int VERTICES = 8; 

    private void Start()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();

        Vector3[] vertices = new Vector3[VERTICES];

        // Create an irregular shape for the asteroid
        for (int i = 0; i < VERTICES; i++)
        {
            // Randomize the radius slightly for each vertex to create an irregular shape
            float angle = i * Mathf.PI * 2 / VERTICES; // Evenly spaced angles
            float radius = scaleFactor + Random.Range(-0.1f, 0.1f); // Adding randomness to the radius
            vertices[i] = new Vector3(Mathf.Cos(angle) * radius, Mathf.Sin(angle) * radius, 0);
        }

        if (lineRenderer == null) { lineRenderer = gameObject.AddComponent<LineRenderer>(); }

        lineRenderer.useWorldSpace = false;                               // Use local space for the line positions.
        lineRenderer.material = new Material(Shader.Find("Unlit/Color")); // Set the material to a color shader.
        lineRenderer.startColor = Color.gray;                             // Set the start color to gray for an asteroid.
        lineRenderer.endColor = Color.gray;                               // Set the end color to gray for an asteroid.
        lineRenderer.startWidth = WIDTH;                                  // Set the starting width of the line.
        lineRenderer.endWidth = WIDTH;                                    // Set the ending width of the line.
        lineRenderer.positionCount = VERTICES + 1;                       // Set the number of vertices in the LineRenderer.

        // Define the positions of the asteroid graphic in local space.
        for (int i = 0; i < VERTICES; i++)
        {
            lineRenderer.SetPosition(i, vertices[i]);
        }

        // Close the loop for the asteroid shape
        lineRenderer.SetPosition(VERTICES, vertices[0]);
    }
}
