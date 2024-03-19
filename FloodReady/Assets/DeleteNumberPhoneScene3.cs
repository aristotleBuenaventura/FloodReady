using UnityEngine;

public class DeleteNumberPhoneScene3 : MonoBehaviour
{
    private NumberArrayManagerScene3 arrayManager;
    private bool canPress = true; // Flag to track if the button can be pressed
    public float cooldownTime = 1f; // Cooldown period in seconds
    public AudioSource keySound;

    private void Start()
    {
        // Find the NumberArrayManager script in the scene
        arrayManager = FindObjectOfType<NumberArrayManagerScene3>();
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
        keySound.Play();
        // Wait for the specified cooldown time
        yield return new WaitForSeconds(cooldownTime);

        // Allow pressing again after the cooldown
        canPress = true;
    }
}
