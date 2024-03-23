using System.Collections;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class PryBarHTP : MonoBehaviour
{
    public OVRGrabber leftGrabber;
    public OVRGrabber rightGrabber;

    // Cooldown time in seconds
    public float interactionCooldown = 2f;

    private float lastInteractionTime;
    private bool hasInteracted = false;


    public void Update()
    {
        /* Check if the user is holding the PryBar using either the left or right OVRGrabber
        if ((leftGrabber != null && leftGrabber.grabbedObject == GetComponent<OVRGrabbable>()) ||
            (rightGrabber != null && rightGrabber.grabbedObject == GetComponent<OVRGrabbable>()))
        { */
            // Check for interactions with BreakableWindow objects
            if (Time.time - lastInteractionTime >= interactionCooldown && !hasInteracted)
            {

                Collider[] colliders = Physics.OverlapBox(transform.position, transform.lossyScale / 2f, transform.rotation);
                foreach (Collider collider in colliders)
                {
                    if (collider.CompareTag("BreakableWindow"))
                    {
                        // Ensure the PryBar is the only object that can break the window
                        ChangeAppearanceHTP window = collider.GetComponent<ChangeAppearanceHTP>();
                        if (window != null && !window.IsBroken)
                        {
                            window.HandleCollision();

                            if (window.IsLastWindow()) // Check if it's the last window
                            {
                            window.HandleCollision();
                            // Optionally mark the task as done for breaking the last window


                        }

                            // Mark the "Break a Window" task as done


                            // Update the last interaction time
                            lastInteractionTime = Time.time;

                            // Assuming survivalToolIcon is not null, set the check and uncheck icons accordingly


                            // Set the flag to true to ensure this block is not executed again

                        }
                    }
                }

          
           /* } */
        }
    }
}
