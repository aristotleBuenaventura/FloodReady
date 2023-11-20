using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class IsGrabFan : OVRGrabbable
{
    public bool isGrabbable = true;

    // Override the GrabBegin method
    public override void GrabBegin(OVRGrabber hand, Collider grabbable)
    {
        if (isGrabbable)
        {
            base.GrabBegin(hand, grabbable);
            // Additional grab logic if needed
        }
    }

    // Override the GrabEnd method
    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        if (isGrabbable)
        {
            base.GrabEnd(linearVelocity, angularVelocity);
            // Additional grab release logic if needed
        }
    }

    // Method to disable grabbable state
    public void DisableGrabbable()
    {
        isGrabbable = false;
    }

    // Method to enable grabbable state
    public void EnableGrabbable()
    {
        isGrabbable = true;
    }
}
