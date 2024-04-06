using UnityEngine;

public class RotateTowardsPlayer : MonoBehaviour
{
    public Transform player; // Reference to the player's transform (e.g., VR camera or headset)

    void Update()
    {
        if (player != null)
        {
            // Calculate direction vector without vertical component
            Vector3 direction = player.position - transform.position;
            direction.y = 0; // Ignore vertical component

            if (direction != Vector3.zero)
            {
                // Debug the direction vector
                Debug.DrawRay(transform.position, direction, Color.green);

                Quaternion rotation = Quaternion.LookRotation(direction);

                // Adjust rotation if needed
                rotation *= Quaternion.Euler(0, 180f, 0); // Add 180 degrees to face the opposite direction if necessary

                transform.rotation = rotation;
            }
        }
    }
}
