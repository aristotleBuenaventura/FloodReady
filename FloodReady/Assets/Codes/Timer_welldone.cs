using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer_welldone : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float elapsedTime; // Changed from remainingTime to elapsedTime
    public float maxTime = 600f; // 10 minutes in seconds

    // Expose player position and rotation in the Inspector
    [Header("Player Settings")]
    public GameObject player;
    public Vector3 desiredPosition = new Vector3(1.0f, 2.0f, 3.0f);
    public Vector3 desiredRotation = new Vector3(45.0f, 90.0f, 0.0f);

    private bool isTimeStopped = false;

    public float ElapsedTime
    {
        get { return elapsedTime; }
    }

    [SerializeField] GameObject loadingScreen;

    void Update()
    {
        // Check if time is not stopped
        if (!isTimeStopped)
        {
            if (elapsedTime < maxTime)
            {
                elapsedTime += Time.deltaTime;

                int minutes = Mathf.FloorToInt(elapsedTime / 60);
                int seconds = Mathf.FloorToInt(elapsedTime % 60);
                timerText.text = string.Format("Elapsed Time: {0:00}:{1:00}", minutes, seconds);
            }
            else
            {
                timerText.color = Color.red;
                Debug.Log("Max Time Reached");

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
        }
    }

    // Function to stop the time
    public void StopTime()
    {
        isTimeStopped = true;
        // You can add any additional logic here when time is stopped
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
