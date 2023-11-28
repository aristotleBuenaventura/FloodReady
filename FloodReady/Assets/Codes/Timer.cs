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
    public CanvasController timesup;

    // Expose player position and rotation in the Inspector
    [Header("Player Settings")]
    public GameObject player;
    public Vector3 desiredPosition = new Vector3(1.0f, 2.0f, 3.0f);
    public Vector3 desiredRotation = new Vector3(45.0f, 90.0f, 0.0f);

    public TextMeshProUGUI welldonetext;

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
                StartCoroutine(ShowTimesUpCoroutine());
                // Set the desired position from the Inspector
                timesup.ShowFailedCanvas();

                // Change the text directly
                if (welldonetext != null)
                {
                    welldonetext.text = "TIME RUN OUT!";
                }
            }
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

IEnumerator ShowTimesUpCoroutine()
{
    yield return new WaitForSeconds(10f); // Wait for 10 seconds
    player.transform.position = desiredPosition;
    player.transform.rotation = Quaternion.Euler(desiredRotation);
    
}


}