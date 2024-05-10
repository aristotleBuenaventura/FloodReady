using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TimerScene3 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    public float InitialTime;
    public RecoveryCanvasController timesup;

    // Expose player position and rotation in the Inspector
    [Header("Player Settings")]
    public GameObject player;

    public TextMeshProUGUI welldonetext;

    public Timer_welldone_3 timesupElapsetime;
    public NumberOfAttemptsScene3 retry;
    public attemptsLeftScene3 finalAttempts;
    public GameObject cubeTeleport;

    private bool isTimerStopped = false; // Variable to control whether the timer is stopped

    void Start()
    {
        cubeTeleport.SetActive(false);
    }

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
                    // Set the desired position from the Inspector
                    timesup.FailedCanvas();
                    timesupElapsetime.StopTime(false);

                    cubeTeleport.SetActive(true);
                    // Change the text directly
                    if (welldonetext != null)
                    {
                        welldonetext.text = "TIME RUN OUT!";
                    }
                    retry.SetNumberOfAttempts();
                    finalAttempts.updateAttempts();
                    // Set the desired position from the Inspector
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

}
