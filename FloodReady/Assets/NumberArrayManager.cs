using TMPro;
using UnityEngine;

public class NumberArrayManager : MonoBehaviour
{
    private string[] numberArray = new string[0]; // Initialize an empty array
    public TextMeshProUGUI textElement; // Expose the TextMeshProUGUI component
    public EscapeCanvasController welldone;

    private void Start()
    {
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
        // Resize the array and add the new number
        System.Array.Resize(ref numberArray, numberArray.Length + 1);
        numberArray[numberArray.Length - 1] = number;

        // Check for emergency call
        CheckEmergencyCall();

        // Update the display
        UpdateDisplay();
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
        // Concatenate the array elements without a comma
        string currentNumber = string.Concat(numberArray);

        // Check if the currentNumber is equal to "161"
        if (currentNumber == "161")
        {
            welldone.WelldoneCanvas();
            // Display a debug message for emergency call
            Debug.Log("Call Emergency");
        }
    }

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
