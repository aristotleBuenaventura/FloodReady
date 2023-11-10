using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject welcomeCanvas;
    public GameObject tvCanvas;
    public GameObject GoBagCanvas;
    public GameObject GoBagCompletedCanvas;
    public GameObject RetrieveGoBagCanvas;
    public GameObject UnplugCableCanvas;
    public GameObject TurnOffBreakerCanvas;
    public GameObject SuccessfullCanvas;
    public MessageCanvas messageCanvas;
    public float switchDelayWelcome = 15f;
    public float switchDelayTV = 41f;


    private void Start()
    {
        // Ensure both canvases start in the desired state
        ShowWelcomeCanvas();
        StartCoroutine(SwitchCanvasAfterDelay());
    }

    private void ShowWelcomeCanvas()
    {
        welcomeCanvas.SetActive(true);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(false);
        GoBagCompletedCanvas.SetActive(false);
        RetrieveGoBagCanvas.SetActive(false);
        UnplugCableCanvas.SetActive(false);
        TurnOffBreakerCanvas.SetActive(false);
        SuccessfullCanvas.SetActive(false);
    }

    private void ShowTVCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(true);
        GoBagCanvas.SetActive(false);
        GoBagCompletedCanvas.SetActive(false);
        RetrieveGoBagCanvas.SetActive(false);
        UnplugCableCanvas.SetActive(false);
        TurnOffBreakerCanvas.SetActive(false);
        SuccessfullCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    private void ShowGoBagCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(true);
        GoBagCompletedCanvas.SetActive(false);
        RetrieveGoBagCanvas.SetActive(false);
        UnplugCableCanvas.SetActive(false);
        TurnOffBreakerCanvas.SetActive(false);
        SuccessfullCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    public void ShowGoBagCompletedCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(false);
        GoBagCompletedCanvas.SetActive(true);
        RetrieveGoBagCanvas.SetActive(false);
        UnplugCableCanvas.SetActive(false);
        TurnOffBreakerCanvas.SetActive(false);
        SuccessfullCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    public void ShowRetrieveGoBagCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(false);
        GoBagCompletedCanvas.SetActive(false);
        RetrieveGoBagCanvas.SetActive(true);
        UnplugCableCanvas.SetActive(false);
        TurnOffBreakerCanvas.SetActive(false);
        SuccessfullCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    private void ShowUnplugCableCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(false);
        GoBagCompletedCanvas.SetActive(false);
        RetrieveGoBagCanvas.SetActive(false);
        UnplugCableCanvas.SetActive(true);
        TurnOffBreakerCanvas.SetActive(false);
        SuccessfullCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    private void ShowTurnOffBreakerCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(false);
        GoBagCompletedCanvas.SetActive(false);
        RetrieveGoBagCanvas.SetActive(false);
        UnplugCableCanvas.SetActive(false);
        TurnOffBreakerCanvas.SetActive(true);
        SuccessfullCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    private void ShowSuccessfulCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(false);
        GoBagCompletedCanvas.SetActive(false);
        RetrieveGoBagCanvas.SetActive(false);
        UnplugCableCanvas.SetActive(false);
        TurnOffBreakerCanvas.SetActive(false);
        SuccessfullCanvas.SetActive(true);
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
