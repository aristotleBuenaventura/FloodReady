using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnplugHolder : MonoBehaviour
{
    public GameObject UnplugCableCanvas;
    public Collider collider1;
    public Collider collider2;
    public Collider collider3;
    public Collider collider4;
    public Collider collider5;


    void Start()
    {
        // Make sure the colliders are enabled initially
        collider1.enabled = true;
        collider2.enabled = true;
        collider3.enabled = true;
        collider4.enabled = true;
        collider5.enabled = true;
        
    }

    void Update()
    {
        // Check if the canvas is not enabled
        if (!UnplugCableCanvas.gameObject.activeSelf)
        {
            // Disable the colliders
            collider1.enabled = false;
            collider2.enabled = false;
            collider3.enabled = false;
            collider4.enabled = false;
            collider5.enabled = false;
        
        }
        else
        {
            // Enable the colliders
            collider1.enabled = true;
            collider2.enabled = true;
            collider3.enabled = true;
            collider4.enabled = true;
            collider5.enabled = true;
       
        }
    }
}
