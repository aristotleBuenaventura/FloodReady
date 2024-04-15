using UnityEngine;
using TMPro;

public class NumberOfAttemptsScene1 : MonoBehaviour
{
    public TextMeshProUGUI attempts;
    private int attemptsToPass;

    // Start is called before the first frame update
    void Start()
    {
        // Get the attempts from PlayerPrefs
        attemptsToPass = PlayerPrefs.GetInt("attempts");

        // If attemptsToPass is zero, initialize it to 0
        if (attemptsToPass == 0)
        {
            attemptsToPass = 0;
        }

        // Set the text of the TextMeshProUGUI component
        attempts.text = attemptsToPass.ToString();
    }

    public void SetNumberOfAttempts()
    {
        // Increment attemptsToPass
        attemptsToPass += 1;

        // Update the TextMeshProUGUI component with the new value
        attempts.text = attemptsToPass.ToString();
    }

    // Call this method when you want to reset attempts
    public void ResetAttempts()
    {
        // Reset attemptsToPass to zero
        attemptsToPass = 0;

        // Update the PlayerPrefs to reflect the reset
        PlayerPrefs.SetInt("attempts", attemptsToPass);
        PlayerPrefs.Save(); // Make sure to save changes immediately

        // Update the TextMeshProUGUI component with the new value
        attempts.text = attemptsToPass.ToString();
    }

    public int GetAttemptsToPass()
    {
        return attemptsToPass;
    }
}
