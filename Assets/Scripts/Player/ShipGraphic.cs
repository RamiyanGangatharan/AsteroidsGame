using UnityEngine;

public class ShipGraphic : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private readonly float scaleFactor = 0.5f;

    private void Start()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();
        if (lineRenderer == null) { lineRenderer = gameObject.AddComponent<LineRenderer>(); }

        lineRenderer.useWorldSpace = false;
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.startColor = Color.white;
        lineRenderer.endColor = Color.white;
        lineRenderer.startWidth = 0.05f;
        lineRenderer.endWidth = 0.05f;
        lineRenderer.positionCount = 4;

        lineRenderer.SetPosition(0, new Vector3(0, 1 * scaleFactor, 0)); // Top point
        lineRenderer.SetPosition(1, new Vector3(-0.5f * scaleFactor, -1 * scaleFactor, 0)); // Bottom left
        lineRenderer.SetPosition(2, new Vector3(0.5f * scaleFactor, -1 * scaleFactor, 0)); // Bottom right
        lineRenderer.SetPosition(3, new Vector3(0, 1 * scaleFactor, 0)); // Close shape
    }
}
