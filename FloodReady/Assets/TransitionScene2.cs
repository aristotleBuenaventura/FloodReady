using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScene2 : MonoBehaviour
{
    public GameObject loadingScreen; // Reference to your loading screen UI element
    public AudioClip oneTimeAudioClip; // Reference to your one-time audio clip
    private bool soundPlayed = false; // Flag to check if sound has been played
    private AudioSource audioSource; // Reference to AudioSource component

    void Start()
    {
        // Get the AudioSource component attached to the same GameObject
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            StartCoroutine(LoadSceneWithAudio("Recovery_Resilience"));
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

        // Activate the loading screen
        loadingScreen.SetActive(true);

        // Load the scene asynchronously
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Deactivate the loading screen after the scene is loaded
        loadingScreen.SetActive(false);
    }
}
