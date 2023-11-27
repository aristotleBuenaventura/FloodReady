using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TurnOffLights1 : MonoBehaviour
{
    public UnityEvent onPress;
    public UnityEvent onRelease;
    public CanvasController exitthehouse;
    private GameObject presser;
    private AudioSource sound;
    private bool isPressed;
    private bool taskIncremented; // Flag to track whether the task has been incremented
    public TaskPercentage turnofflightspercentage;
    public iconforturnoff turnofflightscheck;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
        isPressed = false;
        taskIncremented = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has the tag "TurnOnButton"
        if (other.CompareTag("TurnOnButton") && !isPressed && !taskIncremented)
        {
            // Find all GameObjects with the name "pointlight" and turn them off
            GameObject[] pointLights = GameObject.FindGameObjectsWithTag("pointlight");
            foreach (GameObject pointLight in pointLights)
            {
                pointLight.SetActive(false);
            }

            // Check if the lights are turned off
            if (LightsAreTurnedOff())
            {
                // Mark the task as done
                exitthehouse.ShowExitHouseCanvas();
                turnofflightspercentage.IncrementTaskPercentage(20);
                taskIncremented = true; // Set the flag to true after incrementing the task
                turnofflightscheck.SetCheckIconVisible(true);
                turnofflightscheck.SetUncheckIconVisible(false);
            }

            presser = other.gameObject;
            onPress.Invoke();
            sound.Play();
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
