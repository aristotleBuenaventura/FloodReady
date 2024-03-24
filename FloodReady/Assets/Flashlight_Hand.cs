using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight_Hand : MonoBehaviour
{
    public GameObject flashlight; // Reference to the GameObject to toggle
    public EscapeCanvasController EscapeCanvasController;

    private bool isVisible = false;
    private bool hasShownCanvas = false; // Flag to track if canvas has been shown
    public bool isAllowed = false;
    public GameObject FlashLightCollider;

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
            isVisible = !isVisible;
            flashlight.SetActive(isVisible); // Set the active state of the flashlight
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