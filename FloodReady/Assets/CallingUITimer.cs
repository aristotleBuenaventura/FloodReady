using UnityEngine;
using TMPro;

public class CallingUITimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timer = 0f;

    void Update()
    {
        // Increment the timer
        timer += Time.deltaTime;

        // Calculate minutes and seconds
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);

        // Update the timer text
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
