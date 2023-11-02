using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PryBar : MonoBehaviour
{
    public OVRGrabber leftGrabber; // Assign the left OVRGrabber component in the Unity Editor
    public OVRGrabber rightGrabber; // Assign the right OVRGrabber component in the Unity Editor
    public TaskManager taskManager; // Reference to the TaskManager script

    void Update()
    {
        // Check if the user is holding the PryBar using either the left or right OVRGrabber
        if ((leftGrabber != null && leftGrabber.grabbedObject == GetComponent<OVRGrabbable>()) ||
            (rightGrabber != null && rightGrabber.grabbedObject == GetComponent<OVRGrabbable>()))
        {
            // Check for interactions with BreakableWindow objects
            Collider[] colliders = Physics.OverlapBox(transform.position, transform.lossyScale / 2f, transform.rotation);
            foreach (Collider collider in colliders)
            {
                if (collider.CompareTag("BreakableWindow"))
                {
                    // Ensure the PryBar is the only object that can break the window
                    if (gameObject.name == "PryBar")
                    {
                        BreakableWindow window = collider.GetComponent<BreakableWindow>();
                        if (window != null && !window.isBroken)
                        {
                            window.breakWindow();

                            // Mark the task as done
                            taskManager.MarkTaskAsDone("Break a Window");
                        }
                    }
                }
            }
        }
    }
}
