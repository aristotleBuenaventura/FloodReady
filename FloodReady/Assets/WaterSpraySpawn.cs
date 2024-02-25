using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpraySpawn : MonoBehaviour
{
    public GameObject WaterSpray; // Reference to the GameObject to toggle

    private bool isVisible = false;
    public bool isAllowed = false;

    // Update is called once per frame
    void Start()
    {
        WaterSpray.SetActive(false);
    }

    void Update()
    {
        // Check for button press to toggle visibility
        if (OVRInput.GetDown(OVRInput.Button.Two) && isAllowed) // Change the button as per your requirement
        {
            isVisible = !isVisible;
            WaterSpray.SetActive(isVisible); // Set the active state of the flashlight
        }
    }

    public void Show_WaterSpray(){
        WaterSpray.SetActive(true);
    }

}
