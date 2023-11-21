using UnityEngine;

public class DeleteNumberPhone : MonoBehaviour
{
    private NumberArrayManager arrayManager;
    private bool canPress = true; // Flag to track if the button can be pressed
    public float cooldownTime = 1f; // Cooldown period in seconds

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
            // Call the RemoveNumber function in NumberArrayManager
            StartCoroutine(RemoveNumberWithCooldown());
        }
    }

    // Coroutine for RemoveNumber with cooldown
    private System.Collections.IEnumerator RemoveNumberWithCooldown()
    {
        // Prevent further pressing during the cooldown
        canPress = false;

        // Call the RemoveNumber function in NumberArrayManager
        arrayManager.RemoveNumber();

        // Wait for the specified cooldown time
        yield return new WaitForSeconds(cooldownTime);

        // Allow pressing again after the cooldown
        canPress = true;
    }
}
