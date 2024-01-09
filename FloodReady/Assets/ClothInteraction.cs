using UnityEngine;

public class ClothBoxInteraction : MonoBehaviour
{
    public Cloth clothToInteractWith;  // Reference to the Cloth component to interact with

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the interacting box
        if (collision.collider == GetComponent<Collider>())
        {
            // Apply force-like effect to the cloth
            ApplyForceToCloth(collision);
        }
    }

    void ApplyForceToCloth(Collision collision)
    {
        // Get the contact points from the collision
        ContactPoint[] contactPoints = collision.contacts;

        // Apply force-like effect to the cloth based on the collision normal
        foreach (ContactPoint contactPoint in contactPoints)
        {
            Vector3 forceDirection = contactPoint.normal; // Use the normal as the force direction

            // You may need to adjust the force magnitude based on your requirements
            float forceMagnitude = 0.1f;

            // Apply force-like effect to the cloth using externalAcceleration
            clothToInteractWith.externalAcceleration += forceDirection * forceMagnitude;
        }
    }
}
