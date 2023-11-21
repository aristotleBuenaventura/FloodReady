using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject doorWing;

    private bool isDoorOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        if (doorWing == null)
        {
            Debug.LogError("DoorController: doorWing is not assigned!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isDoorOpen)
        {
            // Perform any actions when the door is open
        }
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == this.gameObject) // Check if the controller is the one entering the trigger
        {
            GrabDoorKnob();
        }
    }

    // Function to handle grabbing the door knob
    void GrabDoorKnob()
    {
        // Perform actions related to grabbing the door knob
        OpenDoor();
    }

    // Function to open the door
    void OpenDoor()
    {
        // Perform actions to open the door
        doorWing.SetActive(false); // Disable the door wing
        isDoorOpen = true;
    }
}
