using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScene1 : MonoBehaviour
{
    public NumberOfAttemptsScene1 attempts;
    public AudioClip oneTimeAudioClip; // Reference to your one-time audio clip
    private bool soundPlayed = false; // Flag to check if sound has been played
    private AudioSource audioSource; // Reference to AudioSource component

    void Start()
    {
        // Get the AudioSource component attached to the same GameObject
        audioSource = GetComponent<AudioSource>();
    }

    // This method is called when the button is clicked
    public void MoveToEvacuation_Essential()
    {
        int numAttempts = attempts.GetAttemptsToPass();
        PlayerPrefs.SetInt("attempts", numAttempts);
        StartCoroutine(LoadSceneWithAudio("Evacuation_Essential"));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") || other.CompareTag("TurnOnButton"))
        {
            int numAttempts = attempts.GetAttemptsToPass();
            PlayerPrefs.SetInt("attempts", numAttempts);
            StartCoroutine(LoadSceneWithAudio("Evacuation_Essential"));
        }
    }

    IEnumerator LoadSceneWithAudio(string sceneName)
    {
        // Play the one-time audio clip if available and not already played
        if (oneTimeAudioClip != null && audioSource != null && !soundPlayed)
        {
            audioSource.PlayOneShot(oneTimeAudioClip);
            soundPlayed = true; // Set flag to indicate sound has been played
        }

        yield return new WaitForSeconds(oneTimeAudioClip.length); // Wait for the audio clip to finish

        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
