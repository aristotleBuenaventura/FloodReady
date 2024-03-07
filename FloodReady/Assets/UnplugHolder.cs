using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnplugHolder : MonoBehaviour
{
    public GameObject UnplugCableCanvas;
    public Collider collider1;
    public Collider collider2;


    // Flag to track if colliders have been enabled
    private bool collidersEnabled = false;

    void Start()
    {
        // Make sure the colliders are disabled initially
        DisableColliders();
    }

    void Update()
    {
        // Check if the canvas is enabled and colliders haven't been enabled yet
        if (UnplugCableCanvas.gameObject.activeSelf && !collidersEnabled)
        {
            // Enable the colliders and set the flag
            EnableColliders();
            collidersEnabled = true;
        }
    }

    // Function to enable colliders
    void EnableColliders()
    {
        collider1.enabled = true;
        collider2.enabled = true;
   
    }

    // Function to disable colliders
    void DisableColliders()
    {
        collider1.enabled = false;
        collider2.enabled = false;

    }
}