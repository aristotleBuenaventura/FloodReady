using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabItem : MonoBehaviour
{
    public OVRGrabber leftGrabber; // Assign the left OVRGrabber component in the Unity Editor
    public OVRGrabber rightGrabber; // Assign the right OVRGrabber component in the Unity Editor
    private bool isGrabbed = false;
    public FlashlightIcon grab;
    public GameObject HintDestroy;
    public AudioSource item;

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
        else
        {
            isGrabbed = false; // Reset the flag when the object is released
        }
    }

    IEnumerator DisappearWithDelay()
    {
        Destroy(HintDestroy);
        yield return new WaitForSeconds(0.5f);
        item.Play();
        grab.SetUncheckIconVisible(false);
        grab.SetCheckIconVisible(true);
    }
}
