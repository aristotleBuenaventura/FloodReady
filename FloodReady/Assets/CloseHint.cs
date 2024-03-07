using UnityEngine;

public class CloseHint : MonoBehaviour
{
    public ShowHintCanvas showHintCanvas;

    private void OnTriggerExit(Collider other)
    {
        // Check if the collider that exited the trigger is the player or controller
        if (other.CompareTag("Hand"))
        {
            // Hide all canvas elements
            showHintCanvas.HideAllCanvas();
        }
    }
}
