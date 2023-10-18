using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ShowCanvasOnButtonPress : MonoBehaviour
{
    public GameObject canvas; // Reference to the Canvas you want to show.

    private bool xButtonPressed = false;

    private void Update()
    {
        List<InputDevice> leftControllers = new List<InputDevice>();

        // Get all input devices with the "Left" characteristic.
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Left, leftControllers);

        // Iterate through the left-hand devices.
        foreach (var leftController in leftControllers)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool xButtonValue))
            {
                if (xButtonValue && !xButtonPressed)
                {
                    ShowCanvas(leftController);
                    xButtonPressed = true;
                }
                else if (!xButtonValue && xButtonPressed)
                {
                    HideCanvas();
                    xButtonPressed = false;
                }
            }
        }
    }

    private void ShowCanvas(InputDevice leftController)
    {
        Vector3 controllerPosition;
        Quaternion controllerRotation;

        // Get the position and rotation of the left controller.
        if (leftController.TryGetFeatureValue(CommonUsages.devicePosition, out controllerPosition) &&
            leftController.TryGetFeatureValue(CommonUsages.deviceRotation, out controllerRotation))
        {
            canvas.transform.position = controllerPosition;
            canvas.transform.rotation = controllerRotation;
            canvas.SetActive(true);
        }
    }

    private void HideCanvas()
    {
        canvas.SetActive(false);
    }
}