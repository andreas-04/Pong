using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionHandler : MonoBehaviour
{
    public GameObject explosionPrefab; // Assign the explosion prefab in the Inspector

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Get the contact point
        Vector2 contactPoint = collision.contacts[0].point;

        // Instantiate the explosion at the contact point
        GameObject explosion = Instantiate(explosionPrefab, contactPoint, Quaternion.identity);

        // Optionally, destroy the explosion after a short delay
        Destroy(explosion, 1.0f); // Destroy after 1 second
    }
}
