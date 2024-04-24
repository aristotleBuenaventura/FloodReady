using UnityEngine;

public class DestroyAfterAudioPlay : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.Play();
            Destroy(gameObject, audioSource.clip.length); // Destroy the GameObject after the length of the audio clip
        }
    }
}