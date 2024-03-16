using UnityEngine;

public class KineGravity : MonoBehaviour
{
    private Rigidbody rb;
    private bool wasGrabbed = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Disable gravity and enable kinematic initially
        rb.useGravity = false;
        rb.isKinematic = true;
    }

    void FixedUpdate()
    {
        // Check if the object has a parent (i.e., it's being held)
        bool isGrabbed = transform.parent != null;

        // If the object was grabbed since the last FixedUpdate, update its state
        if (isGrabbed != wasGrabbed)
        {
            if (isGrabbed)
            {
                // If grabbed, disable gravity and enable kinematic
                rb.useGravity = false;
                rb.isKinematic = true;
            }
            else
            {
                // If not grabbed, enable gravity and disable kinematic
                rb.useGravity = true;
                rb.isKinematic = false;
            }
            // Update the grabbed status
            wasGrabbed = isGrabbed;
        }
    }
}
