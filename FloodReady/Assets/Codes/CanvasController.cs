using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject welcomeCanvas;
    public GameObject tvCanvas;
    public float switchDelay = 5f; // Time in seconds to switch to TVCanvas

    private void Start()
    {
        // Ensure both canvases start in the desired state
        welcomeCanvas.SetActive(true);
        tvCanvas.SetActive(false);
        StartCoroutine(SwitchCanvasAfterDelay());
    }

    private IEnumerator SwitchCanvasAfterDelay()
    {
        // Wait for the specified time
        yield return new WaitForSeconds(switchDelay);

        // Switch to the TVCanvas
        welcomeCanvas.SetActive(false);
        tvCanvas.SetActive(true);
    }
}
