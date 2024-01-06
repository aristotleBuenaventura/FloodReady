using UnityEngine;

public class ParticleCollisionDetector : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        // Check if the collided GameObject has the "Dirt" tag
        if (other.CompareTag("Dirt"))
        {
            // Handle trigger here
            Debug.Log("Nalilinis mo siya!!!");

            // You can add additional logic based on the trigger if needed.
        }
    }
}
