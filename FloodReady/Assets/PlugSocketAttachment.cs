using UnityEngine;

public class PlugSocketAttachment : MonoBehaviour
{
    public bool isAttached { get; private set; } = false;

    // Public variables for manual position and rotation adjustment
    public Vector3 manualPosition = Vector3.zero;
    public Vector3 manualRotation = Vector3.zero;

    private Vector3 originalLocalPosition;
    private Quaternion originalLocalRotation;

    private void OnTriggerEnter(Collider other)
    {
        if (!isAttached && other.CompareTag("Socket")) // Customize the tag as needed
        {
            // Attach logic
            AttachToSocket(other.transform);
        }
    }

    private void AttachToSocket(Transform socket)
    {
        isAttached = true;

        // Disable physics interactions or apply any other necessary adjustments
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true;
        }

        // Store the current local position and rotation of the plug
        originalLocalPosition = transform.localPosition;
        originalLocalRotation = transform.localRotation;

        // Attach the plug to the socket
        transform.SetParent(socket);

        // Set the local position and rotation to the manual values
        transform.localPosition = manualPosition;
        transform.localRotation = Quaternion.Euler(manualRotation);
    }

    public void DetachFromSocket()
    {
        // Restore the original local position and rotation
        transform.localPosition = originalLocalPosition;
        transform.localRotation = originalLocalRotation;

        // Enable physics interactions or apply any other necessary adjustments
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = false;
        }

        // Detach the plug from the socket
        transform.SetParent(null);

        isAttached = false;
    }
}
