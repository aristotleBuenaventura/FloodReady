using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpraySpawnMiniGame : MonoBehaviour
{
    public GameObject WaterSpray; // Reference to the GameObject to toggle

    private bool isVisible = false;

    // Update is called once per frame
    void Start()
    {
        WaterSpray.SetActive(true);
    }

    void Update()
    {
        // Check for button press to toggle visibility
        if (OVRInput.GetDown(OVRInput.Button.Two)) // Change the button as per your requirement
        {
            isVisible = !isVisible;
            WaterSpray.SetActive(isVisible); // Set the active state of the flashlight
        }
    }

}
