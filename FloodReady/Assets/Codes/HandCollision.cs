using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Events;

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
    public VideoPlayer TVScreen;

    private AudioSource audioSource; // Reference to the AudioSource component
    public GameObject TVHint;

    // Flag to check if the task has already been completed
    private bool taskCompleted = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component
                                                   // Subscribe to the loopPointReached event
        TVScreen.loopPointReached += OnVideoEnd;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TurnOnButton") || other.CompareTag("Hand") && canPressButton)
        {
            //StopAllCoroutines(); // Stop any existing coroutines

            if (isButtonDown)
            {

                TVScreen.gameObject.SetActive(false);
                CallSwitchCanvasAfterDelayTV();
                Debug.Log("Button Pressed: TV Turned On");

  
            }
            else
            {

                TVScreen.gameObject.SetActive(true);
                Debug.Log("Button Pressed: TV Turned Off");
                CallSwitchCanvasAfterDelayTV();
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

    private void OnVideoEnd(VideoPlayer vp)
    {
        // Video has finished playing, reset button text to "START"


        TVScreen.gameObject.SetActive(false);
  

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
            Destroy(TVHint);
            Debug.Log("Go bag working");
            StartCoroutine(messageCanvas.SwitchCanvasAfterDelayTV());
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

    private void OnDestroy()
    {
        TVScreen.loopPointReached -= OnVideoEnd;
    }
}
