using UnityEngine;

public class ColliderReenabler : MonoBehaviour
{
    public Collider[] collidersToReenable;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            foreach (var collider in collidersToReenable)
            {
                // Check if the collider is null or has been destroyed
                if (collider != null)
                {
                    collider.isTrigger = true; // Re-enable the collider as a trigger
                }
            }
        }
    }
}
