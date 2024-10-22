using UnityEngine;

public class AsteroidGraphic : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private readonly float scaleFactor = 1f;

    float WIDTH = 0.05f;
    int VERTICES = 16;

    private void Start()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();

        lineRenderer.startWidth = WIDTH;                    // Set the starting width of the line.
        lineRenderer.endWidth = WIDTH;                      // Set the ending width of the line.
        lineRenderer.positionCount = VERTICES + 1;          // +1 to close the loop

        for (int i = 0; i <= VERTICES; i++)
        {
            float angle = i * Mathf.PI * 2 / VERTICES;      // Evenly spaced angles
            float radius = Random.Range(0.4f, 0.6f);        // Random Radius

            // Polar to Cartesian Coordinate Conversion
            float x = Mathf.Cos(angle) * radius * scaleFactor;
            float y = Mathf.Sin(angle) * radius * scaleFactor;

            lineRenderer.SetPosition(i, new Vector3(x, y, 0f));
        }

        // Close the shape
        lineRenderer.SetPosition(VERTICES, lineRenderer.GetPosition(0));
    }
}
