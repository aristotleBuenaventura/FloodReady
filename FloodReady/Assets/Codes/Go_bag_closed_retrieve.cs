using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go_bag_closed_retrieve : MonoBehaviour
{
    public OVRGrabber leftGrabber; // Assign the left OVRGrabber component in the Unity Editor
    public OVRGrabber rightGrabber; // Assign the right OVRGrabber component in the Unity Editor
    private bool isGrabbed = false;
    public CanvasController GoBagRetrieve;
    public TaskPercentage CloseBag;
    public iconforretrievegobag CloseBagCheck;
    public TotalPoints points;
    public retrievegobagcheck checklist;
    public AllowGrabFan fanplug;
    public AllowGrabTVPlugCube tvplugcube;
    public AllowGrabTVPLug tvplug;
    public GameObject GoBagDestroy;


    // You can adjust this variable to control the delay before the object disappears
    public float delayBeforeDisappear = 0.5f;

    void Start()
    {

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
        yield return new WaitForSeconds(delayBeforeDisappear);
        // Deactivate the GameObject instead of destroying it
        gameObject.SetActive(false);
        GoBagRetrieve.ShowUnplugCableCanvas();
        CloseBag.IncrementTaskPercentage(10);
        points.IncrementPoints(1000);
        CloseBagCheck.SetCheckIconVisible(true);
        CloseBagCheck.SetUncheckIconVisible(false);
        checklist.SetCheckIconVisible(true);
        checklist.SetUncheckIconVisible(false);
        fanplug.EnableCollider();
        tvplugcube.EnableCollider();
        tvplug.EnableCollider();

        Destroy(GoBagDestroy);
    }
}
