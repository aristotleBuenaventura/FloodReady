using UnityEngine;
using TMPro;
using UnityEditor;

public class NumberOfAttemptsScene3 : MonoBehaviour
{
    public TextMeshProUGUI attempts;
    private int attemptsToPass;

    // Start is called before the first frame update
    void Start()
    {
        // Get the attempts from PlayerPrefs
        attemptsToPass = PlayerPrefs.GetInt("attemptsScene3");

        // If attemptsToPass is zero, initialize it to 0
        if (attemptsToPass == 0)
        {
            attemptsToPass = 0;
        }

        // Set the text of the TextMeshProUGUI component
        attempts.text = attemptsToPass.ToString();

        // Register the OnPlayModeStateChanged method to be called when the play mode state changes
        EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
    }

    // Callback method to handle play mode state changes
    void OnPlayModeStateChanged(PlayModeStateChange state)
    {
        // If exiting play mode
        if (state == PlayModeStateChange.ExitingPlayMode)
        {
            // Reset the attempts to zero
            attemptsToPass = 0;

            // Update the PlayerPrefs to reflect the reset
            PlayerPrefs.SetInt("attemptsScene3", attemptsToPass);
            PlayerPrefs.Save(); // Make sure to save changes immediately
        }
    }

    public void SetNumberOfAttempts()
    {
        // Increment attemptsToPass
        attemptsToPass += 1;

        // Update the TextMeshProUGUI component with the new value
        attempts.text = attemptsToPass.ToString();
    }

    public int GetAttemptsToPass()
    {
        return attemptsToPass;
    }

    // Unregister the event when the script is destroyed
    private void OnDestroy()
    {
        EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;
    }
}
