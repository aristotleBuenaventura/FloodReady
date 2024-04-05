using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnPlug : MonoBehaviour
{
    public RotateVRObject rotateVRObject;
    public ShowBreakerCanvas ShowCanvas;
    // Flag to track whether the plug is attached
    private bool isPlugAttached = false;
    private bool hasBeenUnplugged = false; // Flag to ensure unplugging happens only once
    public TaskPercentage FanUnplugPercentage;
    public TotalPoints points;
    public FanHeadMovement fanmovement;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Plug"))
        {
            isPlugAttached = true;
            RotateVRObject.SetShouldRotate(true);
            fanmovement.StartMovement();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Plug"))
        {
            // Use a delay before considering it unplugged
            StartCoroutine(DelayedUnplugCheck());
        }
    }

    private IEnumerator DelayedUnplugCheck()
    {
        yield return new WaitForSeconds(0.5f); // Adjust the delay as needed

        // Check if the plug is still attached after the delay and hasn't been unplugged before
        if (!isPlugAttached)
        {
            if (!hasBeenUnplugged)
            {
                FanUnplugPercentage.IncrementTaskPercentage(10);
                points.IncrementPoints(1000);
            }
            fanmovement.StopMovement();
            hasBeenUnplugged = true; // Set the flag to true to ensure this block executes only once
            RotateVRObject.SetShouldRotate(false);
            ShowCanvas.SetBooleanFan(true);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Plug"))
        {
            isPlugAttached = false;
        }
    }
}
