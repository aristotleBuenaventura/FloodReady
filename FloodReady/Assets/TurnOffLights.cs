using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TurnOffLights : MonoBehaviour
{
    public UnityEvent onPress;
    public UnityEvent onRelease;
    public TaskManager taskManager; // Reference to the TaskManager script
    GameObject presser;
    AudioSource sound;
    bool isPressed;
    public EscapeCanvasController ShowdoorJamCanvas;

    void Start()
    {
        sound = GetComponent<AudioSource>();
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
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
                taskManager.MarkTaskAsDone("Switch off the Main Power");
                ShowdoorJamCanvas.ShowdoorJamCanvas();
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
