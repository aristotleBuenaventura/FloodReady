using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public GameObject loadingScreen;

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
        loadingScreen.SetActive(true);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
        loadingScreen.SetActive(false);
    }
}
