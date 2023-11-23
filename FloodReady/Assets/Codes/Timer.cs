using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    public float InitialTime;

    // Expose player position and rotation in the Inspector
    [Header("Player Settings")]
    public GameObject player;
    public Vector3 desiredPosition = new Vector3(1.0f, 2.0f, 3.0f);
    public Vector3 desiredRotation = new Vector3(45.0f, 90.0f, 0.0f);

    public float RemainingTime
    {
        get { return remainingTime; }
    }

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

                // Change player's position and rotation
                if (player != null)
                {
                    // Set the desired position from the Inspector
                    player.transform.position = desiredPosition;

                    // Set the desired rotation from the Inspector
                    player.transform.rotation = Quaternion.Euler(desiredRotation);
                }

                // Wait for 10 seconds before loading the MainMenu
                StartCoroutine(WaitAndLoadScene("MainMenu", 10f));
            }

            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            timerText.color = Color.red;
            // Handle logic when the timer reaches 0 (e.g., stopping the game, showing a message).
        }
    }

    IEnumerator WaitAndLoadScene(string sceneName, float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

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
