using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnPlugTV : MonoBehaviour
{
    public TVController TV;
    public ShowBreakerCanvas ShowCanvas;
    public TaskPercentage TvUnplugPercentage;

    // Flag to track whether the plug is attached
    private bool isPlugAttached = false;
    private bool hasIncrementedPercentage = false;
    private bool isCoroutineRunning = false;
    public TotalPoints points;

    // Start is called before the first frame update
    void Start()
    {
        // Turn off the TV at the start
        TV.TurnOff();

        // Initialize other states
        isPlugAttached = false;
        hasIncrementedPercentage = false;
        isCoroutineRunning = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Plug"))
        {
            isPlugAttached = true;
            // Turn on the TV only if it was turned off initially
            if (!TV.IsTurnedOn)
            {
                TV.TurnOn();
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Plug") && !hasIncrementedPercentage && !isCoroutineRunning)
        {
            // Use a delay before considering it unplugged
            StartCoroutine(DelayedUnplugCheck());
        }
    }

    private IEnumerator DelayedUnplugCheck()
    {
        // Set the flag to indicate that the coroutine is running
        isCoroutineRunning = true;

        yield return new WaitForSeconds(0.5f); // Adjust the delay as needed

        // Check if the plug is still attached after the delay
        if (!isPlugAttached)
        {
            TV.TurnOff();
            ShowCanvas.SetBooleanTV(true);
            TvUnplugPercentage.IncrementTaskPercentage(10);
            points.IncrementPoints(1000);
            hasIncrementedPercentage = true;
        }

        // Reset the flag after the coroutine is complete
        isCoroutineRunning = false;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Plug"))
        {
            isPlugAttached = false;
        }
    }
}
