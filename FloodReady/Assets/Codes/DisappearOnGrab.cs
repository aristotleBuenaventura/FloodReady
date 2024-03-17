using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnGrab : MonoBehaviour
{
    public OVRGrabber leftGrabber;
    public OVRGrabber rightGrabber;
    public EscapeCanvasController ShowMainBreakerCanvas;
    public bool isGrabbed = false;
    public float delayBeforeDisappear = 1.0f;
    public retrieveIcon goBagIcon; // Reference to the retrieveIcon script
    public TaskPercentage retrieveGoBagPercentage;
    public Flashlight_Hand flashlight;
    public RetrieveGoBagScene2Icon task;

    void Start(){
        flashlight = flashlight.GetComponent<Flashlight_Hand>();
    }

    void Update()
    {
        if (leftGrabber == null || rightGrabber == null)
        {
            Debug.LogError("References not properly set!");
            return;
        }

        if ((leftGrabber.grabbedObject == GetComponent<OVRGrabbable>()) ||
            (rightGrabber.grabbedObject == GetComponent<OVRGrabbable>()))
        {
            if (!isGrabbed)
            {
                StartCoroutine(DisappearWithDelay());
                isGrabbed = true;
                
                if (flashlight != null)
                {
                    flashlight.isAllowed = true;
                }

                // Assuming goBagIcon is not null, set the check and uncheck icons accordingly
                if (goBagIcon != null)
                {
                    goBagIcon.SetCheckIconVisible(true);
                    goBagIcon.SetUncheckIconVisible(false);
                    task.SetCheckIconVisible(true);
                    task.SetUncheckIconVisible(false);
                    retrieveGoBagPercentage.IncrementTaskPercentage(20);
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
