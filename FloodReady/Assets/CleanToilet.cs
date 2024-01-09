using UnityEngine;

public class MoveAndScaleUpwardAfterDelay : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed as needed
    public float scaleSpeed = 0.1f; // Adjust the scaling speed as needed
    public float delayBeforeMoving = 1f; // Adjust the delay before the upward movement starts
    public float upwardMovementDuration = 3f; // Duration of the upward movement

    private bool hasDelayElapsed = false;
    private float upwardMovementTimer = 0f;
    private Vector3 initialPosition;

    void Start()
    {
        // Store the initial position for reference
        initialPosition = transform.position;
    }

    void Update()
    {
        // Check if the delay has elapsed
        if (!hasDelayElapsed)
        {
            delayBeforeMoving -= Time.deltaTime;
            if (delayBeforeMoving <= 0f)
            {
                hasDelayElapsed = true;
            }
        }
        else
        {
            // Check if the upward movement duration has not elapsed
            if (upwardMovementTimer < upwardMovementDuration)
            {
                // Move the object upward along the y-axis
                transform.Translate(Vector3.up * speed * Time.deltaTime);

                // Reset the x and z components to their initial values
                Vector3 newPosition = transform.position;
                newPosition.x = initialPosition.x;
                newPosition.z = initialPosition.z;
                transform.position = newPosition;

                // Scale the object uniformly in all axes
                Vector3 currentScale = transform.localScale;
                currentScale += new Vector3(scaleSpeed, scaleSpeed, scaleSpeed) * Time.deltaTime;

                // Assign the new scale to the object
                transform.localScale = currentScale;

                // Update the upward movement timer
                upwardMovementTimer += Time.deltaTime;
            }
        }
    }
}
