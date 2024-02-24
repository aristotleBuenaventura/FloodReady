using UnityEngine;
using TMPro;

public class TaskPercentage : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public int taskPercentage = 0;

    void Update()
    {
        // Update the TextMeshPro text with taskPercentage value
        textMeshPro.text = taskPercentage + "%";
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
