using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScene2 : MonoBehaviour
{
    public NumberOfAttemptsScene2 attempts;

    // This method is called when the button is clicked
    public void MoveToEscape_Survive()
    {
        int numAttempts = attempts.GetAttemptsToPass();
        PlayerPrefs.SetInt("attemptsScene2", numAttempts);
        SceneManager.LoadScene("Escape_Survive", LoadSceneMode.Single);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            int numAttempts = attempts.GetAttemptsToPass();
            PlayerPrefs.SetInt("attemptsScene2", numAttempts);
            SceneManager.LoadScene("Escape_Survive", LoadSceneMode.Single);
        }

    }

}
