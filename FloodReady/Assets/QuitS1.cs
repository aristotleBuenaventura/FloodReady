using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitS1 : MonoBehaviour
{
    public NumberOfAttemptsScene1 attempts;


    public void QuitGame()
    {
        attempts.ResetAttempts();
        Application.Quit();
    }


    public void MoveToMain_Menu()
    {
        attempts.ResetAttempts();
        StartCoroutine(LoadScene("MainMenu"));
    }

    IEnumerator LoadScene(string sceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

}
