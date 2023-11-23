using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PryBar : MonoBehaviour
{
    public OVRGrabber leftGrabber;
    public OVRGrabber rightGrabber;
    public TaskManager taskManager;

    public void Update()
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
                    BreakableWindow window = collider.GetComponent<BreakableWindow>();
                    if (window != null && !window.IsBroken)
                    {
                        window.HandleCollision();

                        // Mark the "Break a Window" task as done
                        taskManager.MarkTaskAsDone("Break a Window");
                    }
                }
            }

            // Mark the "Retrieve a Survival Tool" task as done
            taskManager.MarkTaskAsDone("Retrieve a Survival Tool");
        }
    }
}
