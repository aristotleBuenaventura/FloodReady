using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // This method is called when the button is clicked
    public void MoveToEvacuation_Essential()
    {
        SceneManager.LoadScene("Evacuation_Essential");
    }

    public void MoveToEscape_Survive()
    {
        SceneManager.LoadScene("Escape_Survive");
    }

    public void MoveToRecovery_Resilience()
    {
        SceneManager.LoadScene("Recovery_Resilience");
    }

    public void MoveToMain_Menu()
    {
        SceneManager.LoadScene("MainScene");
    }
}