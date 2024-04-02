using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight_Hand : MonoBehaviour
{
    public GameObject flashlight; // Reference to the GameObject to toggle
    public EscapeCanvasController EscapeCanvasController;
    public TaskPercentage task;
    public TotalPoints points;
    private bool isVisible = false;
    private bool hasShownCanvas = false; // Flag to track if canvas has been shown
    public bool isAllowed = false;
    public GameObject FlashLightCollider;
    public TurnOnFlashlightIcon checklist;
    public TurnOnFlashlightEvalRoom check;
    public GameObject DestoryHint;
    private bool isAdded = false;

    // Update is called once per frame
    void Start()
    {
        flashlight.SetActive(false);
    }

    void Update()
    {
        // Check for button press to toggle visibility
        if (OVRInput.GetDown(OVRInput.Button.Two) && isAllowed == true) // Change the button as per your requirement
        {
            Destroy(DestoryHint);
            isVisible = !isVisible;
            flashlight.SetActive(isVisible); // Set the active state of the flashlight
            checklist.SetCheckIconVisible(true);
            checklist.SetUncheckIconVisible(false);
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            if (isAdded == false)
            {
                task.IncrementTaskPercentage(10);
                points.IncrementPoints(1000);
            }
            isAdded = true;
            FlashLightCollider.SetActive(false);
            if (isVisible && !hasShownCanvas)
            {
                EscapeCanvasController.ShowGoOutCanvas();
                hasShownCanvas = true; // Set the flag to true once canvas is shown
            }

            Debug.Log("flashlight");
        }
    }
}