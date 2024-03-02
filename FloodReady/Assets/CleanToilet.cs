using UnityEngine;

public class MoveAndScaleUpwardAfterDelay : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed as needed
    public float scaleSpeed = 0.1f; // Adjust the scaling speed as needed
    public float delayBeforeMoving = 3f; // Delay before the upward movement starts
    public float duration = 3f; // Duration of the movement
    public GameObject objectToMoveScaleAndDestroy; // Drag your GameObject into this field in the Unity Editor
    public bool goSignal = false; // Set this to true to enable the movement, scaling, and destruction

    private float elapsedTime = 0f;
    private bool hasStartedMoving = false;

    void Update()
    {
        // Check if the goSignal is true
        if (!goSignal)
        {
            return; // Exit the method if goSignal is false
        }

        // Check if the object is null to avoid errors
        if (objectToMoveScaleAndDestroy == null)
        {
            Debug.LogError("Object to move, scale, and destroy is not assigned!");
            return;
        }

        // Check if the delay before moving has elapsed
        if (!hasStartedMoving)
        {
            delayBeforeMoving -= Time.deltaTime;
            if (delayBeforeMoving <= 0f)
            {
                hasStartedMoving = true;
            }
            return;
        }

        // Check if the movement duration has elapsed
        if (elapsedTime >= duration)
        {
            return;
        }

        // Get the current position of the object
        Vector3 currentPosition = objectToMoveScaleAndDestroy.transform.position;

        // Move the object upward along the y-axis
        currentPosition.y += speed * Time.deltaTime;

        // Assign the new position to the object
        objectToMoveScaleAndDestroy.transform.position = currentPosition;

        // Scale the object up
        Vector3 currentScale = objectToMoveScaleAndDestroy.transform.localScale;
        currentScale += new Vector3(scaleSpeed, scaleSpeed, scaleSpeed) * Time.deltaTime;

        // Assign the new scale to the object
        objectToMoveScaleAndDestroy.transform.localScale = currentScale;

        // Update the elapsed time
        elapsedTime += Time.deltaTime;
    }
}
