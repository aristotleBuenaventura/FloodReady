using UnityEngine;

public class MoveScaleAndDestroy : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed as needed
    public float scaleSpeed = 0.1f; // Adjust the scaling speed as needed
    public float destroyTime = 2f; // Time in seconds before the GameObject is destroyed
    public GameObject objectToMoveScaleAndDestroy; // Drag your GameObject into this field in the Unity Editor
    public bool goSignal = false; // Set this to true to enable the movement, scaling, and destruction

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

        // Get the current position of the object
        Vector3 currentPosition = objectToMoveScaleAndDestroy.transform.position;

        // Move the object downward along the y-axis
        currentPosition.y -= speed * Time.deltaTime;

        // Assign the new position to the object
        objectToMoveScaleAndDestroy.transform.position = currentPosition;

        // Scale the object down
        Vector3 currentScale = objectToMoveScaleAndDestroy.transform.localScale;
        currentScale -= new Vector3(scaleSpeed, scaleSpeed, scaleSpeed) * Time.deltaTime;

        // Ensure the object doesn't become too small (optional)
        currentScale = Vector3.Max(currentScale, Vector3.zero);

        // Assign the new scale to the object
        objectToMoveScaleAndDestroy.transform.localScale = currentScale;

        // Countdown to destroy the object after a specified time
        destroyTime -= Time.deltaTime;
        if (destroyTime <= 0f)
        {
            // Destroy the object
            Destroy(objectToMoveScaleAndDestroy);
        }
    }
}
