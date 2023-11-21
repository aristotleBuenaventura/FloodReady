using TMPro;
using UnityEngine;

public class NumberArrayManager : MonoBehaviour
{
    private string[] numberArray = new string[0]; // Initialize an empty array
    public TextMeshProUGUI textElement; // Expose the TextMeshProUGUI component

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

        // Update the display
        UpdateDisplay();
    }

    // Update the display on the TextMeshProUGUI
    private void UpdateDisplay()
    {
        // Ensure the TextMeshProUGUI component is present
        if (textElement != null)
        {
            // Set the text of TextMeshProUGUI to the content of the array
            textElement.text = string.Join(", ", numberArray);
        }
    }
}
