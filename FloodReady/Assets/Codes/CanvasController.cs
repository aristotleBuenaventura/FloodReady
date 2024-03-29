using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject welcomeCanvas;
    public GameObject tvCanvas;
    public GameObject GoBagCanvas;
    public GameObject RetrieveGoBagCanvas;
    public GameObject UnplugCableCanvas;
    public GameObject TurnOffBreakerCanvas;
    public GameObject ExitTheHouseCanvas;
    public GameObject InvisibleWallStair1;
    public GameObject InvisibleWallStair2;
    public GameObject InvisibleWallKitchen;
    public GameObject InvisibleWallBathroom;
    public GameObject SuccessCanvas;
    public GameObject FailedCanvas;
    public GameObject TVRemote;
    public MessageCanvas messageCanvas;
    public float switchDelayWelcome = 15f;
    public float switchDelayTV = 41f;

    private void Start()
    {
        // Ensure both canvases start in the desired state
        ShowWelcomeCanvas();
        StartCoroutine(SwitchCanvasAfterDelay());
        TVRemote.SetActive(false);

    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("HowToPlay", 0);
        PlayerPrefs.Save();
    }

    private void ShowWelcomeCanvas()
    {
        welcomeCanvas.SetActive(true);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(false);
        RetrieveGoBagCanvas.SetActive(false);
        UnplugCableCanvas.SetActive(false);
        TurnOffBreakerCanvas.SetActive(false);
        SuccessCanvas.SetActive(false);
        FailedCanvas.SetActive(false);
        ExitTheHouseCanvas.SetActive(false);
    }

    private void ShowTVCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(true);
        GoBagCanvas.SetActive(false);
        RetrieveGoBagCanvas.SetActive(false);
        UnplugCableCanvas.SetActive(false);
        TurnOffBreakerCanvas.SetActive(false);
        TVRemote.SetActive(true);
        ExitTheHouseCanvas.SetActive(false);
        SuccessCanvas.SetActive(false);
        FailedCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    private void ShowGoBagCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(true);
        RetrieveGoBagCanvas.SetActive(false);
        UnplugCableCanvas.SetActive(false);
        TurnOffBreakerCanvas.SetActive(false);
        InvisibleWallStair1.SetActive(false);
        InvisibleWallStair2.SetActive(false);
        InvisibleWallKitchen.SetActive(false);
        InvisibleWallBathroom.SetActive(false);
        ExitTheHouseCanvas.SetActive(false);
        SuccessCanvas.SetActive(false);
        FailedCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }


    public void ShowRetrieveGoBagCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(false);
        RetrieveGoBagCanvas.SetActive(true);
        UnplugCableCanvas.SetActive(false);
        TurnOffBreakerCanvas.SetActive(false);
        ExitTheHouseCanvas.SetActive(false);
        SuccessCanvas.SetActive(false);
        FailedCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    public void ShowUnplugCableCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(false);
        RetrieveGoBagCanvas.SetActive(false);
        UnplugCableCanvas.SetActive(true);
        TurnOffBreakerCanvas.SetActive(false);
        ExitTheHouseCanvas.SetActive(false);
        SuccessCanvas.SetActive(false);
        FailedCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    public void ShowTurnOffBreakerCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(false);
        RetrieveGoBagCanvas.SetActive(false);
        UnplugCableCanvas.SetActive(false);
        TurnOffBreakerCanvas.SetActive(true);
        ExitTheHouseCanvas.SetActive(false);
        SuccessCanvas.SetActive(false);
        FailedCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    public void ShowExitHouseCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(false);
        RetrieveGoBagCanvas.SetActive(false);
        UnplugCableCanvas.SetActive(false);
        TurnOffBreakerCanvas.SetActive(false);
        ExitTheHouseCanvas.SetActive(true);
        SuccessCanvas.SetActive(false);
        FailedCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    public void ShowSuccessCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(false);
        RetrieveGoBagCanvas.SetActive(false);
        UnplugCableCanvas.SetActive(false);
        TurnOffBreakerCanvas.SetActive(false);
        ExitTheHouseCanvas.SetActive(false);
        SuccessCanvas.SetActive(true);
        FailedCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    public void ShowFailedCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(false);
        RetrieveGoBagCanvas.SetActive(false);
        UnplugCableCanvas.SetActive(false);
        TurnOffBreakerCanvas.SetActive(false);
        ExitTheHouseCanvas.SetActive(false);
        SuccessCanvas.SetActive(false);
        FailedCanvas.SetActive(true);
        messageCanvas.OpenCanvasAgain();
    }
    public void HideAllCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(false);
        RetrieveGoBagCanvas.SetActive(false);
        UnplugCableCanvas.SetActive(false);
        TurnOffBreakerCanvas.SetActive(false);
        ExitTheHouseCanvas.SetActive(false);
        SuccessCanvas.SetActive(false);
        FailedCanvas.SetActive(false);
        
    }






    private IEnumerator SwitchCanvasAfterDelay()
    {
        // Wait for the specified time
        yield return new WaitForSeconds(switchDelayWelcome);

        // Switch to the TVCanvas
        ShowTVCanvas();
    }

    public IEnumerator SwitchCanvasAfterDelayTV()
    {
        // Wait for the specified time
        yield return new WaitForSeconds(switchDelayTV);
        ShowGoBagCanvas();
    }

}
