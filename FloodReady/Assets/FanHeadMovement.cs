using UnityEngine;

public class FanHeadMovement : MonoBehaviour
{
    public float rotationSpeed = 15f; // Adjust this value to change the rotation speed
    public float minRotationZ = -141.299f; // Minimum rotation on the Z-axis
    public float maxRotationZ = -30.591f; // Maximum rotation on the Z-axis
    private float currentRotationZ; // Current rotation on the Z-axis
    private int rotationDirection = 1; // 1 for clockwise, -1 for counterclockwise
    private bool isMovementStopped = false; // Flag to indicate if movement is stopped

    // Start is called before the first frame update
    void Start()
    {
        currentRotationZ = maxRotationZ; // Start at the maximum rotation
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMovementStopped)
        {
            // Calculate the new rotation angle based on the current direction
            currentRotationZ += rotationSpeed * rotationDirection * Time.deltaTime;

            // Check if the rotation reaches either extreme
            if (currentRotationZ <= minRotationZ)
            {
                // If reached the minimum, change direction to clockwise
                rotationDirection = 1;
                currentRotationZ = minRotationZ;
            }
            else if (currentRotationZ >= maxRotationZ)
            {
                // If reached the maximum, change direction to counterclockwise
                rotationDirection = -1;
                currentRotationZ = maxRotationZ;
            }

            // Apply the new rotation
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, currentRotationZ);
        }
    }

    // Function to stop the movement
    public void StopMovement()
    {
        isMovementStopped = true;
        rotationSpeed = 0f; // Set rotation speed to zero
    }

    public void StartMovement()
    {
        isMovementStopped = false;
        rotationSpeed = 15f; // Reset rotation speed
    }
}
