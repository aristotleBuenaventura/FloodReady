using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnGrab : MonoBehaviour
{
    public OVRGrabber leftGrabber; // Assign the left OVRGrabber component in the Unity Editor
    public OVRGrabber rightGrabber; // Assign the right OVRGrabber component in the Unity Editor
    public TaskManager taskManager; // Reference to the TaskManager script
    public bool isGrabbed = false;

    // You can adjust this variable to control the delay before the object disappears
    public float delayBeforeDisappear = 1.0f;

    void Update()
    {
        // Check if the grabbers and taskManager are properly set
        if (leftGrabber == null || rightGrabber == null || taskManager == null)
        {
            // Log an error or handle the situation where references are null
            Debug.LogError("References not properly set!");
            return;
        }

        // Check if the user is holding the object using either the left or right OVRGrabber
        if ((leftGrabber.grabbedObject == GetComponent<OVRGrabbable>()) ||
            (rightGrabber.grabbedObject == GetComponent<OVRGrabbable>()))
        {
            // Mark the "Retrieve the go-bag" task as done
            taskManager.MarkTaskAsDone("Retrieve the go-bag");

            // Check for interactions specific to this object, if needed

            // Destroy the GameObject with a delay
            if (!isGrabbed)
            {
                StartCoroutine(DisappearWithDelay());
                isGrabbed = true;
            }
        }
    }

    IEnumerator DisappearWithDelay()
    {
        yield return new WaitForSeconds(delayBeforeDisappear);
        // Destroy the GameObject instead of deactivating it
        Destroy(gameObject);
    }
}
