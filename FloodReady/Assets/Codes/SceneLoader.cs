using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneChanger : MonoBehaviour
{
    public GameObject loadingScreen;
    public GameObject loadingScreen2;
    public Slider loadingSlider;
    public TextMeshProUGUI progressText;


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

    public void MoveToCleaning_Mini_Game_Quest()
    {
        StartCoroutine(LoadScene("Free_Mode"));
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator LoadScene(string sceneName)
    {
        // Activate the loading screen
        loadingScreen.SetActive(true);
        loadingScreen2.SetActive(true);

        float progress = 0f;

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        asyncLoad.allowSceneActivation = false; //scene will not load while this value is false

        while (progress < 1f)
        {
            progress += 0.01f;

            // Ensure progress stays within the range [0, 1]
            progress = Mathf.Clamp01(progress);

            loadingSlider.value = progress;

            // Update the progress text
            progressText.text = "Loading: " + (progress * 100f).ToString("F0") + "%";

            yield return new WaitForSeconds(0.01f);
        }

        // Allow the scene to be activated
        asyncLoad.allowSceneActivation = true;

        // Wait for the scene to finish loading
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Deactivate the loading screen after the scene is loaded
        loadingScreen.SetActive(false);
        loadingScreen2.SetActive(false);
    }
}
