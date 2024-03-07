using UnityEngine;
using System.Collections; // Add this line to include the System.Collections namespace

public class OpenHintCanvas : MonoBehaviour
{
    public ShowHintCanvas showHintCanvas;
    private bool canTrigger = true; // Flag to control trigger activation

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered the trigger is the player or controller
        if (other.CompareTag("Hand") && canTrigger)
        {
            // Show the next canvas
            showHintCanvas.ShowNextCanvas();
            StartCoroutine(TriggerCooldown()); // Start cooldown coroutine
        }
    }

    // Coroutine to set a cooldown period before the trigger can be activated again
    private IEnumerator TriggerCooldown()
    {
        canTrigger = false; // Disable trigger
        yield return new WaitForSeconds(1f); // Set the cooldown duration (1 second in this example)
        canTrigger = true; // Enable trigger after cooldown
    }
}
