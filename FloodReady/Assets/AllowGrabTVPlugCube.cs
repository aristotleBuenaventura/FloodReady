using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowGrabTVPlugCube : MonoBehaviour
{

    public GameObject TvPlug;

    // Reference to the Box Collider component of the TV plug
    private BoxCollider tvPlugCollider;

    // Start is called before the first frame update
    void Start()
    {
        // Check if the Box Collider component is attached, if not, add one
        if (TvPlug.GetComponent<BoxCollider>() == null)
        {
            // Add Box Collider component if not already present
            tvPlugCollider = TvPlug.AddComponent<BoxCollider>();
        }
        else
        {
            // Get the existing Box Collider component
            tvPlugCollider = TvPlug.GetComponent<BoxCollider>();
        }

        // Disable the Box Collider by default
        DisableCollider();
    }

    // Method to enable the Box Collider
    public void EnableCollider()
    {
        // Ensure we have a valid Box Collider reference
        if (tvPlugCollider != null)
        {
            // Enable the Box Collider component
            tvPlugCollider.enabled = true;
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
        if (tvPlugCollider != null)
        {
            // Disable the Box Collider component
            tvPlugCollider.enabled = false;
        }
        else
        {
            Debug.LogError("Box Collider component not found on the TvPlug GameObject.");
        }
    }
}
