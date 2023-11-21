using UnityEngine;

public class KeyPadCall : MonoBehaviour
{
    private NumberArrayManager arrayManager;
    private bool canPress = true; // Flag to track if the button can be pressed
    private float cooldownTime = 1f; // Cooldown period in seconds

    private void Start()
    {
        // Find the NumberArrayManager script in the scene
        arrayManager = FindObjectOfType<NumberArrayManager>();
    }

    // Called when the collider enters the trigger zone
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered has the tag "TurnOnButton" and can press
        if (other.CompareTag("TurnOnButton") && canPress)
        {
            // Call the CheckEmergencyCall function in NumberArrayManager with a coroutine
            StartCoroutine(CallEmergencyWithCooldown());
        }
    }

    // Coroutine for calling CheckEmergencyCall with cooldown
    private System.Collections.IEnumerator CallEmergencyWithCooldown()
    {
        // Prevent further pressing during the cooldown
        canPress = false;

        // Call the CheckEmergencyCall function in NumberArrayManager
        arrayManager.CheckEmergencyCall();

        // Wait for the specified cooldown time
        yield return new WaitForSeconds(cooldownTime);

        // Allow pressing again after the cooldown
        canPress = true;
    }
}
