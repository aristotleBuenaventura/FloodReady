using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowGrabFan : MonoBehaviour
{
    public GameObject FanPlug;

    // Reference to the Box Collider component of the TV plug
    private BoxCollider fanPlugCollider;

    // Start is called before the first frame update
    void Start()
    {
        // Check if the Box Collider component is attached, if not, add one
        if (FanPlug.GetComponent<BoxCollider>() == null)
        {
            // Add Box Collider component if not already present
            fanPlugCollider = FanPlug.AddComponent<BoxCollider>();
        }
        else
        {
            // Get the existing Box Collider component
            fanPlugCollider = FanPlug.GetComponent<BoxCollider>();
        }

        // Disable the Box Collider by default
        DisableCollider();
    }

    // Method to enable the Box Collider
    public void EnableCollider()
    {
        // Ensure we have a valid Box Collider reference
        if (fanPlugCollider != null)
        {
            // Enable the Box Collider component
            fanPlugCollider.enabled = true;
        }
        else
        {
            Debug.LogError("Box Collider component not found on the TvPlug GameObject.");
        }
    }

    // Method to disable the Box Collider
    public void DisableCollider()
    {
        // Ensure we have a valid Box Collider reference
        if (fanPlugCollider != null)
        {
            // Disable the Box Collider component
            fanPlugCollider.enabled = false;
        }
        else
        {
            Debug.LogError("Box Collider component not found on the TvPlug GameObject.");
        }
    }
}
