using UnityEngine;

public class VolumeDown : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        // Assign the AudioSource component either through the Inspector or programmatically
        // For example, you can assign it in the Inspector by dragging and dropping the GameObject with AudioSource onto this script's AudioSource field.
        
        // Alternatively, you can assign it programmatically like this:
        // audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Lower the volume (0.0 is silent, 1.0 is full volume)
        audioSource.volume = 0.1f; // Adjust this value as needed
    }
}