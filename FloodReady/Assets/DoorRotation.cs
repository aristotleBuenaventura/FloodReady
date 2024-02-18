using UnityEngine;

public class DoorRotation : MonoBehaviour
{
    // Rotation speed when triggered
    public float rotationSpeed = 100.0f;

    // Reference to the GameObject that will be rotated (the door itself)
    public GameObject doorToRotate;

    // Reference to the GameObject representing the pivot point
    public GameObject pivotPoint;

    // Flag to check if the door is currently rotating
    private bool isRotating = false;

    // Maximum rotation angle (in degrees)
    public float maxRotationAngle = 90.0f;

    // Flag to check if the door has rotated
    private bool hasRotated = false;

    // Collider to disable after rotation
    public Collider triggerCollider;

    void Update()
    {
        if (isRotating && !hasRotated)
        {
            RotateDoor();
        }
    }

    void RotateDoor()
    {
        // Calculate the rotation step
        float step = rotationSpeed * Time.deltaTime;

        // Get the pivot position in world space
        Vector3 pivotPosition = pivotPoint.transform.position;

        // Get the direction from the pivot point to the door
        Vector3 directionToDoor = doorToRotate.transform.position - pivotPosition;

        // Rotate the door around the pivot point
        doorToRotate.transform.RotateAround(pivotPosition, Vector3.up, step);

        // Disable the trigger collider
        if (!hasRotated && triggerCollider != null)
        {
            triggerCollider.enabled = false;
        }

        // Check if the door has rotated to the desired angle
        if (Mathf.Abs(doorToRotate.transform.localEulerAngles.y) >= maxRotationAngle)
        {
            // Set the flag back to false to stop rotating
            isRotating = false;

            // Set the rotation flag to true to indicate rotation has occurred
            hasRotated = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the trigger is the assigned triggerObject and rotation hasn't occurred yet
        if (!hasRotated)
        {
            // Start rotating the door
            isRotating = true;
        }
    }
}
