using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public GameObject AsteroidPrefab;
    public float rotationSpeed = 10f;
    public int GRAVITY_DISABLED = 0;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.gravityScale = GRAVITY_DISABLED;
    }
}