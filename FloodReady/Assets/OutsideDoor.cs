using UnityEngine;

public class OpenDoorOnTrigger : MonoBehaviour
{
    // Expose the desired rotation, rotation speed, and target object in the Inspector
    [Header("Transform Settings")]
    public Vector3 desiredRotation = new Vector3(-0.087f, 180.316f, 0.205f);
    public float rotationSpeed = 90.0f; // Speed of rotation
    public GameObject targetObject; // The object to rotate
    public string handTag = "Hand"; // Tag for the hand objects

    private bool isOpening = false; // Flag to check if door is opening

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(handTag))
        {
            Debug.Log("Player detected! Opening door...");

            // Rotate the target object to the desired rotation
            isOpening = true; // Set flag to start rotating
        }
    }

    void Update()
    {
        if (isOpening)
        {
            // Calculate the target rotation
            Quaternion targetRotation = Quaternion.Euler(desiredRotation);

            // Rotate the target object towards the target rotation
            targetObject.transform.rotation = Quaternion.RotateTowards(targetObject.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Check if the target object has reached the target rotation
            if (Quaternion.Angle(targetObject.transform.rotation, targetRotation) < 0.1f)
            {
                isOpening = false; // Stop rotating
            }
        }
    }
}
