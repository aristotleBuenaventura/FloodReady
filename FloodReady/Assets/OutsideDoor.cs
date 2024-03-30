using UnityEngine;

public class OpenDoorOnTrigger : MonoBehaviour
{
    // Expose the desired rotation, rotation speed, and target object in the Inspector
    [Header("Transform Settings")]
    public Vector3 desiredRotation = new Vector3(-0.087f, 180.316f, 0.205f);
    public float rotationSpeed = 90.0f; // Speed of rotation
    public GameObject targetObject; // The object to rotate
    public string handTag = "Hand"; // Tag for the hand objects
    public AudioClip doorOpeningSound; // Sound to play when door opens
    public string handTag2 = "TurnOnButton";
    private bool isOpening = false; // Flag to check if door is opening
    private bool soundPlayed = false; // Flag to check if sound has been played
    private AudioSource audioSource; // Reference to AudioSource component

    void Start()
    {
        // Get the AudioSource component
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(handTag) || other.CompareTag(handTag2))
        {
            Debug.Log("Player detected! Opening door...");

            // Play the door opening sound if available and not already played
            if (doorOpeningSound != null && audioSource != null && !soundPlayed)
            {
                audioSource.PlayOneShot(doorOpeningSound);
                soundPlayed = true; // Set flag to indicate sound has been played
            }

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
