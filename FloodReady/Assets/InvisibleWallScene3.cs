using UnityEngine;

public class InvisibleWallScene3 : MonoBehaviour
{
    // Expose the target object in the Inspector
    [Header("Teleport Settings")]
    public RecoveryCanvasController congratulationcanvas;
    public Timer_welldone stoptime;
    public ScreenTimer screenTimer;
    public NumberOfAttemptsScene3 attempts;
    public attemptsLeftScene3 finalAttempts;
    public GameObject retryBtn;
    public GameObject proceedBtn;
    public GameObject limit;
    public GameObject cube1;
    public GameObject cube2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected! Teleporting...");
            screenTimer.StopTimer();
            attempts.SetNumberOfAttempts();
            finalAttempts.updateAttempts();
            congratulationcanvas.SuccessCanvas();
            stoptime.StopTime(false);
            retryBtn.SetActive(false);
            limit.SetActive(false);
            proceedBtn.SetActive(true);
            cube1.SetActive(true);
            cube2.SetActive(true);
        }
    }

}
