using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PryBarDestroy : MonoBehaviour
{
    public OVRGrabber leftGrabber; // Assign the left OVRGrabber component in the Unity Editor
    public OVRGrabber rightGrabber; // Assign the right OVRGrabber component in the Unity Editor
    private bool isGrabbed = false;
    public GameObject prybarOnHand;
    public GameObject prybarOnTable;

    void Start()
    {
        prybarOnTable.SetActive(true);
        prybarOnHand.SetActive(false);
    }

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
        yield return new WaitForSeconds(0.5f);
        prybarOnHand.SetActive(true);
        prybarOnTable.SetActive(false);
    }
}
