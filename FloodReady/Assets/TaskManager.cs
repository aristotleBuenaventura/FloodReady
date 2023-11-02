using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    public Text taskListText; // Text element to display the task list

    public List<string> taskList = new List<string>();

    private void Start()
    {
        // Initialize the task list
       // Add your tasks here
        AddTask("Retrieve the go-bag");
        AddTask("Switch off the Main Power");
        AddTask("Retrieve a Survival Tool");
        AddTask("Break a Window");
        AddTask("Locate the emergency Device");
        AddTask("Use the device for rescue");
        // You can add more tasks as needed
    }

    void Update()
    {
        // Check for specific actions or conditions to mark tasks as "done"
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MarkTaskAsDone("Break a Window"); // Replace with the actual condition to mark a task as "done"
        }

        // Update the task list display
        UpdateTaskListText();
    }

    // Method to add a new task to the task list
    public void AddTask(string task)
    {
        if (!taskList.Contains(task))
        {
            taskList.Add(task);
        }
    }

    // Method to mark a task as "done"
    public void MarkTaskAsDone(string taskName)
    {
        // Check if the task is in the list and mark it as done
        if (taskList.Contains(taskName))
        {
            taskList.Remove(taskName);
        }
    }

    // Method to update the task list text
    private void UpdateTaskListText()
    {
        taskListText.text = "Task List:\n";
        foreach (string task in taskList)
        {
            taskListText.text += "- " + task + "\n";
        }
    }
}
