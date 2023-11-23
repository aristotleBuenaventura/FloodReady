using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    public float InitialTime; // Add this field to expose InitialTime in the Inspector

    public float RemainingTime
    {
        get { return remainingTime; }
    }

    // Declare the loadingScreen object
    [SerializeField] GameObject loadingScreen;

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;

            if (remainingTime < 0)
            {
                remainingTime = 0;
                Debug.Log("Time's up");
                StartCoroutine(LoadScene("MainMenu"));
            }

            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            // You may want to add some logic for what happens when the timer reaches 0.
            // For example, stopping the game, showing a message, etc.
            timerText.color = Color.red;
        }
    }

    IEnumerator LoadScene(string sceneName)
    {
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
