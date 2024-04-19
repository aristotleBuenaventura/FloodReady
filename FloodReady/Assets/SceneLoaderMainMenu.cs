using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class SceneLoaderMainMenu : MonoBehaviour
{
    public GameObject loadingScreen;
    public GameObject loadingScreen2;
    private int isReady;
    public Slider loadingSlider;
    public TextMeshProUGUI progressText;
    public Slider ScreenloadingSlider;
    public TextMeshProUGUI ScreenprogressText;
    public GameObject Scene1;
    public GameObject Scene2;
    public GameObject Scene3;
    public int isReadyValue;
    public Button[] buttonsToCooldown; // Buttons to apply cooldown to
    public float cooldownDuration = 1f; // Cooldown duration in seconds
    public GameObject ScreenDisplay;
    public GameObject ScreenLoading;

    void Start()
    {
        isReady = PlayerPrefs.GetInt("HowToPlay");
        Debug.Log("SceneLoaderMainMenu script - HowToPlay value: " + isReady);
        Scene1.SetActive(false);
        Scene2.SetActive(false);
        Scene3.SetActive(false);
        ScreenDisplay.SetActive(true);
        ScreenLoading.SetActive(false);
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
        if (isReady == 0)
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
        ScreenDisplay.SetActive(false);
        ScreenLoading.SetActive(true);

        foreach (Button button in buttonsToCooldown)
        {
            button.interactable = false; // Disable the button
        }

        

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

            ScreenloadingSlider.value = progress;

            // Update the progress text
            ScreenprogressText.text = "Loading: " + (progress * 100f).ToString("F0") + "%";

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

        yield return new WaitForSeconds(cooldownDuration);

        foreach (Button button in buttonsToCooldown)
        {
            button.interactable = true; // Enable the button after cooldown
        }
    }

}
