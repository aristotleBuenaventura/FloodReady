using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatRescue : MonoBehaviour
{
    public GameObject boat; // Reference to the boat GameObject
    public float speed = 1f; // Speed at which the boat moves along the x-axis
    public float moveDuration = 4f; // Duration for which the boat should move

    private float elapsedTime = 0f; // Variable to track elapsed time
    public AudioSource boatSounds;

    void Update()
    {
        // Check if the boat has moved for the specified duration
        if (elapsedTime < moveDuration)
        {
            // Move the boat along the x-axis
            Vector3 movement = new Vector3( 0f, 0f, speed * Time.deltaTime);
            boat.transform.Translate(movement);
            // Update the elapsed time
            elapsedTime += Time.deltaTime;
            boatSounds.enabled = true;
        }
        else
        {
            // If the duration has passed, disable the script
            enabled = false;
        }
    }
}
