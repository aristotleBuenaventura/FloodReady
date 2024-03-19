using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScene3 : MonoBehaviour
{
    public NumberOfAttemptsScene3 attempts;

    // This method is called when the button is clicked
    public void MoveToRecovery_Resilience()
    {
        int numAttempts = attempts.GetAttemptsToPass();
        PlayerPrefs.SetInt("attemptsScene3", numAttempts);
        SceneManager.LoadScene("Recovery_Resilience", LoadSceneMode.Single);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            int numAttempts = attempts.GetAttemptsToPass();
            PlayerPrefs.SetInt("attemptsScene3", numAttempts);
            SceneManager.LoadScene("Recovery_Resilience", LoadSceneMode.Single);
        }

    }
}
