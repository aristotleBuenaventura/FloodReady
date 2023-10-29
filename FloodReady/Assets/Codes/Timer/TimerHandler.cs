using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerHandler : MonoBehaviour
{
    private float startTime;
    private string textTime;
    private float guiTime;

    private int minutes;
    private int seconds;
    private int fraction;

    public TextMeshProUGUI textField;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        guiTime = Time.time - startTime; // Calculation for guiTime
        minutes = (int)(guiTime / 60); // Calculation for minutes
        seconds = (int)(guiTime % 60); // Calculation for seconds
        fraction = (int)((guiTime * 100) % 100);
        textTime = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, fraction); // Added fraction to the format string

        if (minutes >= 1)
        {
            textField.text = "Game Over";
        }
        else
        {
            textField.text = textTime;
        }
    }
}
