using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class TaskList : MonoBehaviour
{
    public TextMeshProUGUI textElement; // Reference to the TextMeshPro Text element
    public TaskManager taskManager; // Reference to the TaskManager script

    void Update()
    {
        if (textElement != null && taskManager != null)
        {
            List<string> taskList = taskManager.taskList;

            // Create a string to display the list content
            string listContent = "";

            foreach (string task in taskList)
            {
                listContent += "- " + task + "\n";
            }

            // Update the TextMeshPro Text element with the list content
            textElement.text = listContent;
        }
    }
}
