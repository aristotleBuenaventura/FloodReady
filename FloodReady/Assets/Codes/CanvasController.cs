using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject welcomeCanvas;
    public GameObject tvCanvas;
    public GameObject GoBagCanvas;
    public MessageCanvas messageCanvas;
    public float switchDelay = 5f;
    public float switchDelayTV = 5f;


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
    }

    private void ShowTVCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(true);
        GoBagCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    private void ShowGoBagCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(false);
        GoBagCanvas.SetActive(true);
        messageCanvas.OpenCanvasAgain();
    }

    private IEnumerator SwitchCanvasAfterDelay()
    {
        // Wait for the specified time
        yield return new WaitForSeconds(switchDelay);

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
