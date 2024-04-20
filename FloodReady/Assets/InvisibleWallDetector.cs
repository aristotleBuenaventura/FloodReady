using UnityEngine;
using System.Collections;

public class InvisibleWallDetector : MonoBehaviour
{
    // Expose the target object in the Inspector
    [Header("Teleport Settings")]
    public CanvasController congratulationcanvas;
    public Timer_welldone welldomeStopTime;
    public ScreenTimer screenTimer;
    public NumberOfAttemptsScene1 attempts;
    public attemptsLeft finalAttempts;
    public GameObject retryBtn;
    public GameObject proceedBtn;
    public GameObject cube1;
    public GameObject cube2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            congratulationcanvas.ShowSuccessCanvas();
            welldomeStopTime.StopTime(false);
            screenTimer.StopTimer();
            attempts.SetNumberOfAttempts();
            finalAttempts.updateAttempts();
            retryBtn.SetActive(false);
            proceedBtn.SetActive(true);
            cube1.SetActive(true); // This cube is activated immediately
            StartCoroutine(ActivateCube2WithDelay());
        }
    }

    private IEnumerator ActivateCube2WithDelay()
    {
        yield return new WaitForSeconds(0.5f); // Wait for 0.5 seconds
        cube2.SetActive(true); // Activate cube2 after the delay
    }
}
