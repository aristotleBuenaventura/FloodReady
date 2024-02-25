using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSprayDisappear : MonoBehaviour
{
    public OVRGrabber leftGrabber; // Assign the left OVRGrabber component in the Unity Editor
    public OVRGrabber rightGrabber; // Assign the right OVRGrabber component in the Unity Editor
    private bool isGrabbed = false;
    public WaterSpraySpawn waterspray;

    // You can adjust this variable to control the delay before the object disappears
    public float delayBeforeDisappear = 0.5f;

    public findthewaternozzleIcon check;

    void Update()
    {
        // Check if the user is holding the object using either the left or right OVRGrabber
        if ((leftGrabber != null && leftGrabber.grabbedObject == GetComponent<OVRGrabbable>()) ||
            (rightGrabber != null && rightGrabber.grabbedObject == GetComponent<OVRGrabbable>()))
        {
            // Deactivate the GameObject with a delay
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
        waterspray.Show_WaterSpray();
        waterspray.isAllowed = true;
        check.SetCheckIconVisible(true);
        check.SetUncheckIconVisible(false);
        // Deactivate the GameObject instead of destroying it
        gameObject.SetActive(false);
        
    }
}
