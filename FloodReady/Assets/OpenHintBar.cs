using System.Collections;
using UnityEngine;

public class OpenHintBar : MonoBehaviour
{
    public GameObject EnergyBar;
    public ShowHintCanvas hintCanvas;
    public Collider[] otherHintColliders; // Array of colliders from other hint functions
    public float initialColliderDuration = 2f; // Initial duration for which other colliders are disabled when this canvas is activated
    private bool canActivate = true; // Flag to track if canvas activation is allowed

    // Start is called before the first frame update
    void Start()
    {
        EnergyBar.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {
            // Disable other hint colliders
            DisableOtherHintColliders();

            hintCanvas.ShowEnergyCanvas();

            
            
                StartCoroutine(StartColliderDuration());
           
        }
    }

    // Coroutine for cooldown period
    private IEnumerator StartColliderDuration()
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
