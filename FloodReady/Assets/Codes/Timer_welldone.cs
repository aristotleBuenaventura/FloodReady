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

                // Change player's position and rotation
                if (player != null)
                {
                    // Set the desired position from the Inspector
                    player.transform.position = desiredPosition;

                    // Set the desired rotation from the Inspector
                    player.transform.rotation = Quaternion.Euler(desiredRotation);
                }

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
