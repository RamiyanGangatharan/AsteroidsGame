using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public GameObject ProjectilePrefab;
    public float rotationSpeed = 200f;
    public int GRAVITY_DISABLED = 0;

    private PlayerMovement playerMovement;
    private PlayerShooting playerShooting;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.gravityScale = GRAVITY_DISABLED;
        playerMovement = new PlayerMovement(rigidBody, rotationSpeed);
        playerShooting = new PlayerShooting(ProjectilePrefab);
    }

    private void Update()
    {
        playerMovement.HandleMovement();
        playerShooting.HandleShooting(transform);
    }
}