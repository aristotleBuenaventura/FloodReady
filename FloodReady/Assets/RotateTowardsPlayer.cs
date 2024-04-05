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
                Quaternion rotation = Quaternion.LookRotation(direction);
                transform.rotation = rotation;
            }
        }
    }
}
