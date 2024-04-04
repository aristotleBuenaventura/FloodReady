using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Make sure to add this for UI elements
using UnityEditor;

public class SceneLoaderMainMenu : MonoBehaviour
{
    public GameObject loadingScreen; // Reference to your loading screen UI element
    private int isReady;
    public GameObject Scene1;
    public GameObject Scene2;
    public GameObject Scene3;
    public int isReadyValue;

    void Start()
    {
        isReady = PlayerPrefs.GetInt("HowToPlay");
        Debug.Log("SceneLoaderMainMenu script - HowToPlay value: " + isReady);
        Scene1.SetActive(false);
        Scene2.SetActive(false);
        Scene3.SetActive(false);
    }
    // Unregister the event when the script is destroyed
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("HowToPlay", 0);
        PlayerPrefs.Save();
    }



    // This method is called when the button is clicked
    public void MoveToEvacuation_Essential()
    {
        if (isReady == 1)
        {
            StartCoroutine(LoadScene("Evacuation_Essential"));
        }
        else
        {
            Scene1.SetActive(true);
        }
        
    }

    public void MoveToEscape_Survive()
    {
        if (isReady == 1)
        {
            StartCoroutine(LoadScene("Escape_Survive"));
        }
        else
        {
            Scene2.SetActive(true);
        }
    }

    public void MoveToRecovery_Resilience()
    {
        if (isReady == 1)
        {
            StartCoroutine(LoadScene("Recovery_Resilience"));
        }
        else
        {
            Scene3.SetActive(true);
        }
    }

    public void MoveToMain_Menu()
    {
        StartCoroutine(LoadScene("MainMenu"));
    }

    public void MoveToHow_to_Play()
    {
        StartCoroutine(LoadScene("How_to_Play"));
    }

    public void MoveToCleaning_Mini_Game_Quest()
    {
        StartCoroutine(LoadScene("Cleaning_Free_Mode_Test"));
    }

    public void QuitGame()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;
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
