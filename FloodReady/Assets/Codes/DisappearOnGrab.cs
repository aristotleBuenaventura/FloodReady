using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnGrab : MonoBehaviour
{
    public OVRGrabber leftGrabber;
    public OVRGrabber rightGrabber;
    public TaskManager taskManager;
    public EscapeCanvasController ShowMainBreakerCanvas;
    public bool isGrabbed = false;
    public float delayBeforeDisappear = 1.0f;
    public retrieveIcon goBagIcon; // Reference to the retrieveIcon script

    void Update()
    {
        if (leftGrabber == null || rightGrabber == null || taskManager == null)
        {
            Debug.LogError("References not properly set!");
            return;
        }

        if ((leftGrabber.grabbedObject == GetComponent<OVRGrabbable>()) ||
            (rightGrabber.grabbedObject == GetComponent<OVRGrabbable>()))
        {
            taskManager.MarkTaskAsDone("Retrieve the go-bag");

            if (!isGrabbed)
            {
                StartCoroutine(DisappearWithDelay());
                isGrabbed = true;

                // Assuming goBagIcon is not null, set the check and uncheck icons accordingly
                if (goBagIcon != null)
                {
                    goBagIcon.SetCheckIconVisible(true);
                    goBagIcon.SetUncheckIconVisible(false);
                }
            }
        }
    }

    IEnumerator DisappearWithDelay()
    {
        yield return new WaitForSeconds(delayBeforeDisappear);
        Destroy(gameObject);
        ShowMainBreakerCanvas.ShowMainBreakerCanvas();
    }
}
