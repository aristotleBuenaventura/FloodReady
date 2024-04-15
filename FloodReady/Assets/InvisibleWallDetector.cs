using UnityEngine;

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
            
        }
    }

}
