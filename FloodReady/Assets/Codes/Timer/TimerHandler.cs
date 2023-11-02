using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerHandler : MonoBehaviour
{
    private float startTime;
    private string textTime;
    private float remainingTime = 600.0f; // 10 minutes in seconds
    private bool isTimerRunning = false;

    public TextMeshProUGUI textField;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimerRunning)
        {
            float elapsedTime = Time.time - startTime;
            remainingTime = Mathf.Max(0, 600.0f - elapsedTime); // Update the remaining time

            int minutes = (int)(remainingTime / 60); // Calculation for minutes
            int seconds = (int)(remainingTime % 60); // Calculation for seconds
            int fraction = (int)((remainingTime * 100) % 100);
            textTime = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, fraction);

            if (remainingTime <= 0)
            {
                isTimerRunning = false;
                textField.text = "Game Over";
            }
            else
            {
                textField.text = textTime;
            }
        }
    }

    public void StartTimer()
    {
        isTimerRunning = true;
    }
}
