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
    public GameObject InvisibleWallStair1;
    public GameObject InvisibleWallStair2;
    public GameObject InvisibleWallKitchen;
    public GameObject InvisibleWallBathroom;
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

    private void ShowWelcomeCanvas()
    {
        welcomeCanvas.SetActive(true);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(false);
        RetrieveGoBagCanvas.SetActive(false);
        UnplugCableCanvas.SetActive(false);
        TurnOffBreakerCanvas.SetActive(false);
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
        messageCanvas.OpenCanvasAgain();
    }

    public void ShowSuccessfulCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(false);
        RetrieveGoBagCanvas.SetActive(false);
        UnplugCableCanvas.SetActive(false);
        TurnOffBreakerCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
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
