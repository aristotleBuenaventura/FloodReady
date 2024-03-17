using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class attemptsLeftScene3 : MonoBehaviour
{
    public NumberOfAttemptsScene3 attempts;
    public TextMeshProUGUI attemptsText;
    int numAttempts;
    public GameObject retry;
    public GameObject proceed;
    public GameObject finalLimit;
    // Start is called before the first frame update
    void Start()
    {
        numAttempts = attempts.GetAttemptsToPass();
        int finalAttempts = 3 - numAttempts;
        attemptsText.text = finalAttempts.ToString();
        retry.SetActive(false);
        proceed.SetActive(true);
        finalLimit.SetActive(false);
    }

    public void updateAttempts()
    {
        numAttempts = attempts.GetAttemptsToPass();
        int finalAttempts = 3 - numAttempts;
        attemptsText.text = finalAttempts.ToString();
        if (numAttempts < 3)
        {
            retry.SetActive(true);
            proceed.SetActive(false);
            finalLimit.SetActive(false);
        }
        else if (numAttempts >= 3)
        {
            retry.SetActive(false);
            proceed.SetActive(false);
            finalLimit.SetActive(true);
        }
        Debug.Log("ATTEMPTS" + numAttempts);
    }

    public int GetAttemptsToPass2()
    {
        return numAttempts;
    }
}
