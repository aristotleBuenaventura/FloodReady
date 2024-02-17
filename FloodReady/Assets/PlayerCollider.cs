using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public GameObject playerTag; // Assign the player GameObject to this variable in the Inspector
    public GameObject[] objectsToDisable; // Assign the GameObjects you want to disable to this array variable in the Inspector
    public RecoveryCanvasController ShowclosegasleakCanvas;
    private Collider gasFindHintCollider; // Reference to the GasFindHint collider
    private int objectsDisabledCount = 0; // Counter for the number of objects disabled by the player

    void Start()
    {
        // Get the collider component of the GasFindHint
        gasFindHintCollider = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerTag)
        {
            // Disable the collider to prevent further collisions
            gasFindHintCollider.enabled = false;

            // Disable the next object if available
            if (objectsDisabledCount < objectsToDisable.Length)
            {
                GameObject objToDisable = objectsToDisable[objectsDisabledCount];
                if (objToDisable.activeSelf)
                {
                    objToDisable.SetActive(false);
                    objectsDisabledCount++;
                }
            }

            // Check if all objects have been disabled
            if (objectsDisabledCount >= objectsToDisable.Length)
            {
                // Show the canvas
                ShowclosegasleakCanvas.ShowfindnozzleCanvas();
            }
        }
    }
}
