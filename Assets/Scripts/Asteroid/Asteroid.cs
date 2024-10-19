using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public GameObject asteroidPrefab;  // Reference to the asteroid prefab
    public float velocity = 2f;        // Movement speed of the asteroid
    public float spawnInterval = 2f;   // Time between spawns
    public float asteroidSpawnZ = 0f;  // Z position to ensure it's within the camera's view

    // Reference to the main camera
    private Camera mainCamera;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;

        //// Start the asteroid spawning process
        //InvokeRepeating(nameof(SpawnAsteroid), 0f, spawnInterval);
    }

    // Method to spawn an asteroid within the camera bounds
    public void SpawnAsteroid()
    {
        // Generate a random position within the camera's view
        Vector3 spawnPosition = GetRandomPositionWithinCameraView();

        // Instantiate the asteroid at the spawn position
        Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);
    }

    // Get a random position within the camera's visible view
    private Vector3 GetRandomPositionWithinCameraView()
    {
        // Get the camera's world boundaries
        Vector3 bottomLeft = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, -mainCamera.transform.position.z));
        Vector3 topRight = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, -mainCamera.transform.position.z));

        // Generate random X and Y within these bounds
        float randomX = Random.Range(bottomLeft.x, topRight.x);
        float randomY = Random.Range(bottomLeft.y, topRight.y);

        // Return a random position within the visible bounds (Z is 0 for 2D)
        return new Vector3(randomX, randomY, asteroidSpawnZ);
    }
}
