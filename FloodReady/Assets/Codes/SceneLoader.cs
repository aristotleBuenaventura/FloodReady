using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public GameObject loadingScreen;
    public AudioClip oneTimeAudioClip; // Reference to your one-time audio clip
    private bool soundPlayed = false; // Flag to check if sound has been played
    private AudioSource audioSource; // Reference to AudioSource component

    void Start()
    {
        // Get the AudioSource component attached to the same GameObject
        audioSource = GetComponent<AudioSource>();
    }

    public void MoveToScene(string sceneName)
    {
        StartCoroutine(LoadScene(sceneName));
    }

    IEnumerator LoadScene(string sceneName)
    {
        loadingScreen.SetActive(true);

        // Play the one-time audio clip if available and not already played
        if (oneTimeAudioClip != null && audioSource != null && !soundPlayed)
        {
            audioSource.PlayOneShot(oneTimeAudioClip);
            soundPlayed = true; // Set flag to indicate sound has been played
        }

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        loadingScreen.SetActive(false);
    }
}
