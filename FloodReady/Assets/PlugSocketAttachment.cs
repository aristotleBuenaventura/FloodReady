using UnityEngine;

public class PlugSocketAttachment : MonoBehaviour
{
    private bool isAttached = false;

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
        GetComponent<Rigidbody>().isKinematic = true;

        // Attach the plug to the socket
        transform.SetParent(socket);

        // Optional: Adjust the position and rotation if needed
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
    }
}
