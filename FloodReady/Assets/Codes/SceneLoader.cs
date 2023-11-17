using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // This method is called when the button is clicked
    public void MoveToEvacuation_Essential()
    {
        SceneManager.LoadSceneAsync("Evacuation_Essential");
    }
    
    public void MoveToEscape_Survive()
    {
        SceneManager.LoadSceneAsync("Escape_Survive");
    }

    public void MoveToRecovery_Resilience()
    {
        SceneManager.LoadSceneAsync("Recovery_Resilience");
    }

    public void MoveToMain_Menu()
    {
        SceneManager.LoadSceneAsync("MainScene");
    }
    public void MoveToHow_to_Play()
    {
        SceneManager.LoadSceneAsync("How_to_Play");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}