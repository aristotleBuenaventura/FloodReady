using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TurnOffLightsScene1 : MonoBehaviour
{
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    AudioSource sound;
    bool isPressed;
    public CanvasController messageCanvas;

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
            if (LightsAreTurnedOff(pointLights))
            {
                // Mark the task as done
                messageCanvas.ShowExitHouseCanvas();
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

    private bool LightsAreTurnedOff(GameObject[] pointLights)
    {
        // Add logic here to check if the lights are turned off
        // You might check the state of the lights or their visibility status
        // For simplicity, let's assume the lights are considered off if there are no active point lights

        return pointLights.Length == 0;
    }
}
