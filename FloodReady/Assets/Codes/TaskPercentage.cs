using UnityEngine;
using TMPro;

public class TaskPercentage : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    private int taskPercentage = 0;

    void Update()
    {
        // Update the TextMeshPro text with taskPercentage value
        textMeshPro.text = "Task Percentage: " + taskPercentage + "%";
    }

    // Function to increment taskPercentage by a specified value
    public void IncrementTaskPercentage(int incrementValue)
    {
        taskPercentage += incrementValue;
    }

    public void DecrementTaskPercentage(int decrementValue)
    {
        taskPercentage -= decrementValue;
    }
}
