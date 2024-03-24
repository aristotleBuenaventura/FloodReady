using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Make sure to add this for UI elements

public class SceneChanger : MonoBehaviour
{
    public GameObject loadingScreen; // Reference to your loading screen UI element

    // This method is called when the button is clicked
    public void MoveToEvacuation_Essential()
    {
        StartCoroutine(LoadScene("Evacuation_Essential"));
    }

    public void MoveToEscape_Survive()
    {
        StartCoroutine(LoadScene("Escape_Survive"));
    }

    public void MoveToRecovery_Resilience()
    {
        StartCoroutine(LoadScene("Recovery_Resilience"));
    }

    public void MoveToMain_Menu()
    {
        StartCoroutine(LoadScene("MainMenu"));
    }

    public void MoveToHow_to_Play()
    {
        StartCoroutine(LoadScene("How_to_Play"));
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator LoadScene(string sceneName)
    {
        // Activate the loading screen
        loadingScreen.SetActive(true);

        // Load the scene synchronously
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Deactivate the loading screen after the scene is loaded
        loadingScreen.SetActive(false);
    }
}
