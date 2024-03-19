using TMPro;
using UnityEngine;
using System.Collections;

public class NumberArrayManager : MonoBehaviour
{
    private string[] numberArray = new string[0]; // Initialize an empty array
    public TextMeshProUGUI textElement; // Expose the TextMeshProUGUI component
    public EscapeCanvasController welldone;

    public iconfordial161 icon161;
    public TaskPercentage dial161increment;
    private bool isTaskPercentageIncremented = false;
    public GameObject portal;
    public Dial161Scene2Icon task;

    public GameObject boat;
    public TotalPoints points;

    private void Start()
    {
        portal.SetActive(false);
        // Ensure the TextMeshProUGUI component is present
        if (textElement == null)
        {
            // If not set in the Inspector, try to find the TextMeshProUGUI component on the same GameObject
            textElement = GetComponent<TextMeshProUGUI>();

            // If still not found, log an error
            if (textElement == null)
            {
                Debug.LogError("TextMeshProUGUI component not found. Please assign it in the Inspector or make sure it is on the same GameObject.");
            }
        }
    }

    // Add a number to the array
    public void AddNumber(string number)
{
    // Check if the array has reached its maximum length (10)
    if (numberArray.Length < 10)
    {
        // Resize the array and add the new number
        System.Array.Resize(ref numberArray, numberArray.Length + 1);
        numberArray[numberArray.Length - 1] = number;

        // Update the display
        UpdateDisplay();
    }
    // Optionally, you can display an error message if the limit is reached
    else
    {
        Debug.LogWarning("Maximum number limit reached (10). Cannot add more numbers.");
    }
}

    // Remove the last number from the array
    public void RemoveNumber()
    {
        // Check if there are any numbers to remove
        if (numberArray.Length > 0)
        {
            // Resize the array to remove the last number
            System.Array.Resize(ref numberArray, numberArray.Length - 1);

            // Update the display
            UpdateDisplay();
        }
    }

    // Check for emergency call when the array is "161"
    public void CheckEmergencyCall()
    {
        string currentNumber = string.Concat(numberArray);

        if (currentNumber == "161" && !isTaskPercentageIncremented)
        {
            welldone.WelldoneCanvas();
            icon161.SetCheckIconVisible(true);
            icon161.SetUncheckIconVisible(false);
            task.SetCheckIconVisible(true);
            task.SetUncheckIconVisible(false);
            portal.SetActive(true);
            boat.SetActive(true);
            // Increment the task percentage only if it hasn't been done before
            dial161increment.IncrementTaskPercentage(10);
            points.IncrementPoints(1000);
            isTaskPercentageIncremented = true;

            // StartCoroutine(DelayedSuccessCanvas(10f));
            
            Debug.Log("Call Emergency");
        }
    }

    // private IEnumerator DelayedSuccessCanvas(float delay)
    // {
    //     yield return new WaitForSeconds(delay);
    //     welldone.SuccessCanvas();
    // }


    // Update the display on the TextMeshProUGUI
    private void UpdateDisplay()
    {
        // Ensure the TextMeshProUGUI component is present
        if (textElement != null)
        {
            // Concatenate the array elements without a comma
            textElement.text = string.Concat(numberArray);
        }
    }
}
