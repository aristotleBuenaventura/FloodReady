using System.Collections;
using UnityEngine;

public class OpenHintCanned : MonoBehaviour
{
    public GameObject Canned;
    public ShowHintCanvas hintCanvas;
    public Collider[] otherHintColliders; // Array of colliders from other hint functions
    public float initialColliderDuration = 2f; // Initial duration for which other colliders are disabled when this canvas is activated
    private bool canActivate = true; // Flag to track if canvas activation is allowed

    // Start is called before the first frame update
    void Start()
    {
        Canned.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {
            // Disable other hint colliders
            DisableOtherHintColliders();

            hintCanvas.ShowCannedCanvas();

          

            // Check if HintCanvasManager exists
         
                StartCoroutine(StartCooldown());
         
        }
    }

    // Coroutine for cooldown period
    private IEnumerator StartCooldown()
    {
        canActivate = false; // Disable canvas activation
        yield return new WaitForSeconds(initialColliderDuration); // Wait for initial duration
        canActivate = true; // Enable canvas activation
        // Re-enable other hint colliders
        EnableOtherHintColliders();
    }

    // Disable other hint colliders
    private void DisableOtherHintColliders()
    {
        foreach (var collider in otherHintColliders)
        {
            collider.enabled = false;
        }
    }

    // Re-enable other hint colliders
    private void EnableOtherHintColliders()
    {
        foreach (var collider in otherHintColliders)
        {
            collider.enabled = true;
        }
    }
}
