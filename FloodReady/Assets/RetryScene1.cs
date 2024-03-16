using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScene1 : MonoBehaviour
{
    public NumberOfAttemptsScene1 attempts;

    // This method is called when the button is clicked
    public void MoveToEvacuation_Essential()
    {
        int numAttempts = attempts.GetAttemptsToPass();
        PlayerPrefs.SetInt("attempts", numAttempts);
        SceneManager.LoadScene("Evacuation_Essential", LoadSceneMode.Single);
    }

}
