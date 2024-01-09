using System.Collections;
using UnityEngine;

public class GasBottleRotation : MonoBehaviour
{
    // Rotation speed when not colliding
    public float rotationSpeed = 100.0f;

    // Rotation speed when colliding
    public float collisionRotationSpeed = 20.0f;

    // Reference to the Rigidbody component
    private Rigidbody rb;

    // Flag to control coroutine execution
    private bool isRotating = false;

    // Rotation duration in seconds
    private float remainingRotationDuration = 5.0f;

    // GameObject used as a trigger to start rotation
    public GameObject triggerObject;

    public GameObject triggerObject1;

    // Flag to check if the trigger object is currently colliding
    private bool isTriggerColliding = false;

    // Flag to check if the rotation has occurred
    private bool hasRotated = false;

    void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Rotate the GasBottle around its local forward axis (Z-axis) only when the trigger object is colliding
        if (isTriggerColliding && remainingRotationDuration > 0.0f && !hasRotated)
        {
            RotateGasBottle(collisionRotationSpeed);
        }
    }

    void RotateGasBottle(float speed)
    {
        // Rotate the GasBottle around its local forward axis (Z-axis)
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);

        // Decrease the remaining rotation duration
        remainingRotationDuration -= Time.deltaTime;

        // Check if the rotation duration has elapsed
        if (remainingRotationDuration <= 0.0f)
        {
            // Set the flag back to false to allow rotation again
            isRotating = false;

            // Set the rotation flag to true to indicate rotation has occurred
            hasRotated = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the trigger is the assigned triggerObject and rotation hasn't occurred yet
        if ((other.gameObject == triggerObject || other.gameObject == triggerObject1) && !hasRotated)
        {
            // Set the flag to true indicating the trigger object is colliding
            isTriggerColliding = true;

            // Set the remaining rotation duration
            remainingRotationDuration = 3.0f; // Set your desired rotation duration here
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the trigger is the assigned triggerObject
        if (other.gameObject == triggerObject || other.gameObject == triggerObject1)
        {
            // Set the flag to false indicating the trigger object is not colliding anymore
            isTriggerColliding = false;
        }
    }
<<<<<<< Updated upstream
}
=======
}
>>>>>>> Stashed changes
