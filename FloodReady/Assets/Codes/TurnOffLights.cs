using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TurnOffLights : MonoBehaviour
{
    public UnityEvent onPress;
    public UnityEvent onRelease;
    public EscapeCanvasController EscapeCanvasController;
    public turnoffIcon lightsIcon; // Reference to the TurnOffIcon script
    public TaskPercentage MainBreakerPercentage;
    GameObject presser;
    AudioSource sound;
    bool isPressed;
    private bool mainBreakerPercentageIncremented = false;
    public TurnOffMainBreakerScene2Icon task;
    public AudioClip buttonPressSound; // Sound to play when button is pressed
    public Flashlight_Hand flashlight;
    private bool soundPlayed = false; // Flag to check if sound has been played
    public TotalPoints points;
    public GameObject hintMainbreaker;

    void Start()
    {
        flashlight = flashlight.GetComponent<Flashlight_Hand>();
        sound = GetComponent<AudioSource>();
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed && (other.CompareTag("Hand") || other.CompareTag("TurnOnButton")))
        {
            // Find all GameObjects with the name "pointlight" and turn them off
            GameObject[] pointLights = GameObject.FindGameObjectsWithTag("pointlight");
            foreach (GameObject pointLight in pointLights)
            {
                pointLight.SetActive(false);
            }
            if (flashlight != null)
            {
                flashlight.isAllowed = true;
            }

            // Check if the lights are turned off
            if (LightsAreTurnedOff())
            {
                // Check if the task percentage has already been incremented
                if (!mainBreakerPercentageIncremented)
                {
                    Destroy(hintMainbreaker);
                    // Mark the task as done
                    EscapeCanvasController.ShowFlashlightCanvas();
                    MainBreakerPercentage.IncrementTaskPercentage(20);
                    points.IncrementPoints(2000);
                    task.SetCheckIconVisible(true);
                    task.SetUncheckIconVisible(false);

                    // Set the flag to true to ensure this block is not executed again
                    mainBreakerPercentageIncremented = true;
                }

                // Assuming lightsIcon is not null, set the check and uncheck icons accordingly
                if (lightsIcon != null)
                {
                    lightsIcon.SetCheckIconVisible(true);
                    lightsIcon.SetUncheckIconVisible(false);
                }
            }

            presser = other.gameObject;
            onPress.Invoke();
            if (buttonPressSound != null && sound != null && !soundPlayed)
            {
                sound.PlayOneShot(buttonPressSound);
                soundPlayed = true; // Set flag to indicate sound has been played
            }
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            // You can add logic here if needed when the button is released
            onRelease.Invoke();
            isPressed = false;
        }
    }

    private bool LightsAreTurnedOff()
    {
        // Add logic here to check if the lights are turned off
        // You might check the state of the lights or their visibility status
        // For simplicity, let's assume the lights are considered off if there are no active point lights

        GameObject[] pointLights = GameObject.FindGameObjectsWithTag("pointlight");
        return pointLights.Length == 0;
    }
}
