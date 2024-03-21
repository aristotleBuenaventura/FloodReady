using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintDialS2 : MonoBehaviour
{
    public GameObject Dial;
    public ShowHintCanvasScene2 hintCanvas;
    public Collider[] otherHintColliders; // Array of colliders from other hint functions
    public float initialColliderDuration = 2f; // Initial duration for which other colliders are disabled when this canvas is activated
    private bool canActivate = true; // Flag to track if canvas activation is allowed


    void Start()
    {
        Dial.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {

            DisableOtherHintColliders();

            hintCanvas.ShowDial161Canvas();
       


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


    private void DisableOtherHintColliders()
    {
        foreach (var collider in otherHintColliders)
        {
            collider.isTrigger = false;
        }
    }

    // Re-enable other hint colliders
    private void EnableOtherHintColliders()
    {
        foreach (var collider in otherHintColliders)
        {
            collider.isTrigger = true;
        }
    }
}

