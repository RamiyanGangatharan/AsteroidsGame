using System.Collections.Generic;
using UnityEngine;

public class ProjectilePool : MonoBehaviour
{
    public GameObject projectilePrefab; // Prefab of the projectile
    public int initialPoolSize = 10; // Initial size of the pool
    public int maxPoolSize = 20; // Maximum size of the pool

    private Queue<GameObject> projectilePool = new Queue<GameObject>();

    void Start()
    {
        CreatePool(initialPoolSize); // Create the initial pool of projectiles
    }

    public void CreatePool(int size)
    {
        for (int i = 0; i < size; i++)
        {
            GameObject projectile = Instantiate(projectilePrefab);
            projectile.SetActive(false); // Disable the projectile initially
            projectilePool.Enqueue(projectile); // Add it to the pool
        }
    }

    public GameObject GetProjectile()
    {
        // If there are no projectiles in the pool, regenerate more if under max pool size
        if (projectilePool.Count == 0)
        {
            if (projectilePool.Count < maxPoolSize)
            {
                CreatePool(1); // Create one new projectile if the pool is empty and below max size
                Debug.Log("Generated a new projectile.");
            }
            else
            {
                Debug.LogWarning("Maximum pool size reached. Cannot create more projectiles.");
                return null; // Return null if the pool has reached max size
            }
        }

        // Retrieve a projectile from the pool
        GameObject projectile = projectilePool.Dequeue();
        projectile.SetActive(true); // Activate the projectile
        return projectile;
    }

    public void ReturnProjectile(GameObject projectile)
    {
        // Check if the projectile being returned is already in the pool
        if (!projectilePool.Contains(projectile))
        {
            projectile.SetActive(false); // Disable the projectile
            if (projectilePool.Count < maxPoolSize) // Ensure there is space before adding back
            {
                projectilePool.Enqueue(projectile); // Add it back to the pool
                Debug.Log($"Returned projectile to pool: {projectile.name}. Current pool size: {projectilePool.Count}.");
            }
            else
            {
                Debug.LogWarning("Cannot return projectile; pool size limit reached.");
                Destroy(projectile); // Destroy it if the pool is full
            }
        }
        else
        {
            Debug.LogWarning("Trying to return a projectile that is already in the pool.");
        }
    }
}
