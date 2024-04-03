using UnityEngine;

public class GasBottleRotation : MonoBehaviour
{
    // Expose the desired rotation in the Inspector
    [Header("Rotation Settings")]
    public Vector3 desiredRotation = new Vector3(0.0f, 90.0f, 0.0f); // Desired rotation

    public float rotationSpeed = 90.0f; // Speed of rotation

    private Collider gasBottleCollider; // Reference to the GasBottle collider
    private bool hasShownCanvas = false; // Flag to track if canvas has been shown
    private bool isRotating = false; // Flag to check if rotation is in progress

    public string handTag = "Hand"; // Tag for the hand objects
    public RecoveryCanvasController ShowchecwholehouseCanvas; // Reference to the canvas controller
    private AudioSource audioSource;

    public closevalveIcon check;
    public TaskPercentage task;
    public TotalPoints points;
    public CloseGasValveIcon checklist;


    void Start()
    {
        // Get the collider component of the GasBottle
        gasBottleCollider = GetComponent<Collider>();
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the specified tag and the canvas hasn't been shown yet
        if (other.CompareTag(handTag) && !hasShownCanvas)
        {
            Debug.Log("Hand detected! Rotating gas bottle and showing canvas...");

            // Rotate the gas bottle
            isRotating = true;
            DisableSound();
            // Show the canvas
            ShowchecwholehouseCanvas.ShowchecwholehouseCanvas();
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            checklist.SetCheckIconVisible(true);
            checklist.SetUncheckIconVisible(false);
            task.IncrementTaskPercentage(5);
            points.IncrementPoints(500);
            // Disable the collider to prevent further collisions
            gasBottleCollider.enabled = false;

            // Set the flag to true to indicate that the canvas has been shown
            hasShownCanvas = true;
        }
    }

    void Update()
    {
        if (isRotating)
        {
            // Calculate the target rotation
            Quaternion targetRotation = Quaternion.Euler(desiredRotation);

            // Rotate the gas bottle towards the target rotation
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Check if the gas bottle has reached the target rotation
            if (Quaternion.Angle(transform.rotation, targetRotation) < 0.1f)
            {
                isRotating = false; // Stop rotating
            }
        }
    }
    void DisableSound()
    {
        audioSource.enabled = false;
    }
}
