using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight_Hand : MonoBehaviour
{
    public GameObject flashlight; // Reference to the GameObject to toggle

    private bool isVisible = false;
    public bool isAllowed = false;

    // Update is called once per frame
    void Start()
    {
        flashlight.SetActive(false);
    }

    void Update()
{
    // Check for button press to toggle visibility
    if (OVRInput.GetDown(OVRInput.Button.Two) && isAllowed == true) // Change the button as per your requirement
    {
        isVisible = !isVisible;
        flashlight.SetActive(isVisible); // Set the active state of the flashlight
        Debug.Log("flashlight");
    }
}

}
