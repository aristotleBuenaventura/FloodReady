using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class attemptsLeft : MonoBehaviour
{
    public NumberOfAttemptsScene1 attempts;
    public TextMeshProUGUI attemptsText;
    int numAttempts;
    // Start is called before the first frame update
    void Start()
    {
        numAttempts = attempts.GetAttemptsToPass();
        int finalAttempts = 3-numAttempts;
        attemptsText.text = finalAttempts.ToString();
    }

    public void updateAttempts()
    {
        numAttempts = attempts.GetAttemptsToPass();
        int finalAttempts = 3 - numAttempts;
        attemptsText.text = finalAttempts.ToString();
    }

    public int GetAttemptsToPass()
    {
        return numAttempts;
    }
}
