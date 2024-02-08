using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioValve : MonoBehaviour
{
    public GameObject playerTag; // Assign the player GameObject to this variable in the Inspector
    public GameObject soundSource; // Assign the GameObject with AudioSource in the Inspector
    public AudioClip collisionSound; // Assign the collision sound in the Inspector

    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component from the soundSource GameObject
        audioSource = soundSource.GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerTag)
        {
            // If the hint collides with the player, deactivate it
            gameObject.SetActive(false);

            // Play the collision sound
            if (audioSource != null && collisionSound != null)
            {
                audioSource.PlayOneShot(collisionSound);
            }
        }
    }
}
