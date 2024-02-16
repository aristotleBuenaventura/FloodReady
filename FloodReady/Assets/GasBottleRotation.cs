using System.Collections;
using UnityEngine;

public class GasBottleRotation : MonoBehaviour
{
    public string handTag = "Hand"; // Tag for the hand objects
    public RecoveryCanvasController ShowchecwholehouseCanvas;
    private Collider gasBottleCollider; // Reference to the GasBottle collider
    private bool hasShownCanvas = false; // Flag to track if canvas has been shown

    void Start()
    {
        // Get the collider component of the GasBottle
        gasBottleCollider = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the specified tag and the canvas hasn't been shown yet
        if (other.CompareTag(handTag) && !hasShownCanvas)
        {
            // Show the canvas
            ShowchecwholehouseCanvas.ShowchecwholehouseCanvas();

            // Disable the collider to prevent further collisions
            gasBottleCollider.enabled = false;

            // Set the flag to true to indicate that the canvas has been shown
            hasShownCanvas = true;
        }
    }
}