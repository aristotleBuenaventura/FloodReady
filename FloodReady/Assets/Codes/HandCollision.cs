using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCollision : MonoBehaviour
{
    public float buttonCooldown = 2.0f; // Adjust the cooldown time as needed
    public CanvasController messageCanvas;
    private bool isButtonDown = false;
    private bool canPressButton = true;
    public TaskPercentage remoteTask;
    public iconforturnontv check;
    public AudioClip buttonPressSound; // Sound to play when button is pressed
    public TotalPoints points;
    public TurnOnTVCheck checklist;
    public GameObject TVScreen;

    private AudioSource audioSource; // Reference to the AudioSource component

    // Flag to check if the task has already been completed
    private bool taskCompleted = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TurnOnButton") && canPressButton)
        {
            StopAllCoroutines(); // Stop any existing coroutines

            if (isButtonDown)
            {
                TVScreen.SetActive(false);
                Debug.Log("Button Pressed: TV Turned Off");
                CallSwitchCanvasAfterDelayTV();
            }
            else
            {
                TVScreen.SetActive(true);
                CallSwitchCanvasAfterDelayTV();
                Debug.Log("Button Pressed: TV Turned On");
            }

            isButtonDown = !isButtonDown;
            canPressButton = false;
            StartCoroutine(ButtonCooldown());

            // Play the button press sound if available
            if (buttonPressSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(buttonPressSound);
            }
        }
    }

    private IEnumerator ButtonCooldown()
    {
        yield return new WaitForSeconds(buttonCooldown);
        canPressButton = true;
    }

    public void CallSwitchCanvasAfterDelayTV()
    {
        // Check if the task has already been completed
        if (!taskCompleted)
        {
            StartCoroutine(messageCanvas.SwitchCanvasAfterDelayTV());
            Debug.Log("Go bag working");
            remoteTask.IncrementTaskPercentage(10);
            points.IncrementPoints(1000);
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            checklist.SetCheckIconVisible(true);
            checklist.SetUncheckIconVisible(false);
            // Set the flag to indicate that the task has been completed
            taskCompleted = true;
        }
    }
}
