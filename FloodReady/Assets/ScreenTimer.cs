using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScreenTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    public float InitialTime;
    private bool isTimerStopped = false; // Variable to control whether the timer is stopped
    void Update()
    {
        if (!isTimerStopped && remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;

            if (remainingTime < 0)
            {
                remainingTime = 0;
                Debug.Log("Time's up");
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
