using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlungerGrab : MonoBehaviour
{
    public OVRGrabber leftGrabber;
    public OVRGrabber rightGrabber;
    private bool hasIncrementedPercentage = false;
    public grabtheplungericon task;
    public FindPlungerIcon checklist;
    public TotalPoints points;
    public TaskPercentage percent;
    public RecoveryCanvasController canvas;
    public GameObject DestroyHint;

    void Update()
    {
        // Check if the user is holding the PryBar using either the left or right OVRGrabber
        if ((leftGrabber != null && leftGrabber.grabbedObject == GetComponent<OVRGrabbable>()) ||
            (rightGrabber != null && rightGrabber.grabbedObject == GetComponent<OVRGrabbable>()))
        {
            // Check if the percentage has already been incremented
            if (!hasIncrementedPercentage)
            {
                Destroy(DestroyHint);
                task.SetCheckIconVisible(true);
                task.SetUncheckIconVisible(false);
                checklist.SetCheckIconVisible(true);
                checklist.SetUncheckIconVisible(false);
                percent.IncrementTaskPercentage(5);
                points.IncrementPoints(5);
                canvas.ShowplungedtoiletCanvas();
                hasIncrementedPercentage = true;
            }

        }

    }
}
