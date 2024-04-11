using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnPlugTV : MonoBehaviour
{
    public GameObject TVScreen;
    public ShowBreakerCanvas ShowCanvas;
    public TaskPercentage TvUnplugPercentage;

    // Flag to track whether the plug is attached
    private bool isPlugAttached = true;
    private bool hasIncrementedPercentage = false;
    private bool isCoroutineRunning = false;
    public TotalPoints points;
    public bool IsGoBag = true;

    // Start is called before the first frame update
    void Start()
    {
        // Turn off the TV at the start
        if (TVScreen != null)
        {
            TVScreen.SetActive(false);
        }

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
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Plug") && !hasIncrementedPercentage && !isCoroutineRunning)
        {
            // Use a delay before considering it unplugged
            StartCoroutine(DelayedUnplugCheck());
        }

        // Reevaluate plug attachment status
        isPlugAttached = other.CompareTag("Plug");
    }

    private IEnumerator DelayedUnplugCheck()
    {
        // Set the flag to indicate that the coroutine is running
        isCoroutineRunning = true;

        yield return new WaitForSeconds(0.5f); // Adjust the delay as needed

        // Check if the plug is still attached after the delay
        if (!isPlugAttached)
        {
            TVScreen.SetActive(false);
            ShowCanvas.SetBooleanTV(true);
            TvUnplugPercentage.IncrementTaskPercentage(5);
            points.IncrementPoints(500);
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

    public void setIsGoBagtoFalse()
    {
        IsGoBag = false;
    }
}
