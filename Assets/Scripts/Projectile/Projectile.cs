using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float velocity = 15f; 
    public float projectileHalfLife = 1.0f; 

    void Start() { rigidBody = GetComponent<Rigidbody2D>(); }
}