using System.Collections;
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
    public Vector3 desiredPosition = new Vector3(3.755f, 5.062f, 8.019f);
    public Vector3 desiredRotation = new Vector3(0f, 90.112f, 0f);

    public TextMeshProUGUI welldonetext;

    public Timer_welldone timesupElapsetime;

    private bool isTimerStopped = false; // Variable to control whether the timer is stopped

    [SerializeField] GameObject loadingScreen;

    void Update()
    {
        if (!isTimerStopped && remainingTime > 0)
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
                    timesupElapsetime.StopTime();

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
    }

    // Function to stop the timer
    public void StopTimer()
    {
        isTimerStopped = true;
    }

    IEnumerator ShowTimesUpCoroutine()
    {
        yield return new WaitForSeconds(10f); // Wait for 10 seconds
        player.transform.position = desiredPosition;
        player.transform.rotation = Quaternion.Euler(desiredRotation);
    }
}
