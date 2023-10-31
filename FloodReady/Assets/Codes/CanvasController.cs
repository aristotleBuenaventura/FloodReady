using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject welcomeCanvas;
    public GameObject tvCanvas;
    public MessageCanvas messageCanvas;
    public float switchDelay = 5f; // Time in seconds to switch to TVCanvas


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
    }

    private void ShowTVCanvas()
    {
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(true);
        messageCanvas.OpenCanvasAgain();
    }

    private IEnumerator SwitchCanvasAfterDelay()
    {
        // Wait for the specified time
        yield return new WaitForSeconds(switchDelay);

        // Switch to the TVCanvas
        ShowTVCanvas();
    }
}
