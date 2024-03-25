using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSprayDisappear : MonoBehaviour
{
    public OVRGrabber leftGrabber; // Assign the left OVRGrabber component in the Unity Editor
    public OVRGrabber rightGrabber; // Assign the right OVRGrabber component in the Unity Editor
    private bool isGrabbed = false;
    public WaterSpraySpawn waterspray;
    public RecoveryCanvasController canvasController;
    public TaskPercentage task;
    public CleaningCollider colliderWall;
    public CleaningChecklistCanvas canvas;
    // You can adjust this variable to control the delay before the object disappears
    public float delayBeforeDisappear = 0.5f;
    public findthewaternozzleIcon check;
    public TotalPoints points;
    public FindWaterNozzleICon checklist;


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
        checklist.SetCheckIconVisible(true);
        checklist.SetUncheckIconVisible(false);
        canvasController.ShowcleanlivingCanvas();
        task.IncrementTaskPercentage(10);
        points.IncrementPoints(1000);
        colliderWall.LivingRoomColliders();
        canvas.ShowLivingRoomCanvas();

        // Deactivate the GameObject instead of destroying it
        gameObject.SetActive(false);
        
    }
}
