using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class PlayerIsReady : MonoBehaviour
{
    public int isReadyValue;
    void Start()
    {
        // Set PlayerPrefs value to 1 when the game starts
        PlayerPrefs.SetInt("HowToPlay", 1);
        PlayerPrefs.Save(); // Make sure to save changes immediately
        Debug.Log("PlayerIsReady script - PlayerPrefs HowToPlay set to 1");
    }


    public void LoadNextScene()
    {
        // Load the next scene
        SceneManager.LoadScene("MainMenu");
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("HowToPlay", 0);
        PlayerPrefs.Save();
    }




}
