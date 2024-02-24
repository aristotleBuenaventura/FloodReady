using UnityEngine;
using TMPro;

public class PercentageHandCanvas : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public TaskPercentage taskPercentageScript; // Reference to the TaskPercentage script

    void Start()
    {
        // Assuming you have a reference to the GameObject with the TaskPercentage script attached
        // If not, you can find it using other methods like FindObjectOfType or GameObject.Find
        taskPercentageScript = FindObjectOfType<TaskPercentage>();
    }

    void Update()
    {
        // Check if taskPercentageScript is not null before updating the text
        if (taskPercentageScript != null)
        {
            // Update the TextMeshPro text with taskPercentage value from TaskPercentage script
            textMeshPro.text = taskPercentageScript.taskPercentage + "%";
        }
    }
}
