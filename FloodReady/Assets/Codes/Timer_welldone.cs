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



    private bool isTimeStopped = false;
    public TotalPoints points;

    public float ElapsedTime
    {
        get { return elapsedTime; }
    }


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
                timerText.text = string.Format("Elapsed Time: {0:00} minutes and {1:00} seconds", minutes, seconds);
            }
            else
            {
                timerText.color = Color.red;
                Debug.Log("Max Time Reached");

           

            }
        }
    }

    // Function to stop the time
    public void StopTime(bool isDead)
    {
        isTimeStopped = true;
        if (!isDead)
        {
            // Debug log if elapsedTime is less than or equal to 3 minutes
            if (elapsedTime <= 180) // 3 minutes in seconds
            {
                points.IncrementPoints(30);
            }
            // Debug log if elapsedTime is less than or equal to 5 minutes
            else if (elapsedTime <= 300) // 5 minutes in seconds
            {
                points.IncrementPoints(15);
            }
            else if (elapsedTime <= 480) // 8 minutes in seconds
            {
                points.IncrementPoints(7);
            }
            else
            {
                points.IncrementPoints(3);
            }
        }
       


        // You can add any additional logic here when time is stopped
    }

}
