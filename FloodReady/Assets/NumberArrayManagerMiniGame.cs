using TMPro;
using UnityEngine;
using System.Collections;

public class NumberArrayManagerMiniGame : MonoBehaviour
{
    private string[] numberArray = new string[0]; // Initialize an empty array
    public TextMeshProUGUI textElement; // Expose the TextMeshProUGUI component
    public GameObject dial;
    public GameObject call;
    public GameObject Contact;

    private void Start()
    {

        // Ensure the TextMeshProUGUI component is present
        dial.SetActive(false);
        call.SetActive(false);
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

        if (currentNumber == "161")
        {

            dial.SetActive(true);

            Contact.SetActive(false);
            // StartCoroutine(DelayedSuccessCanvas(10f));

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
