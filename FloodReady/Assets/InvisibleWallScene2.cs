using UnityEngine;

public class InvisibleWallScene2 : MonoBehaviour
{
    // Expose the target object in the Inspector
    [Header("Teleport Settings")]
    public EscapeCanvasController congratulationcanvas;
    public Timer_welldone stoptime;
    public ScreenTimer screenTimer;
    public NumberOfAttemptsScene2 attempts;
    public attemptsLeftScene2 finalAttempts;
    public GameObject retryBtn;
    public GameObject proceedBtn;
    public GameObject maximumText;
    public GameObject evalroom;
    public GameObject toDestroy;
    public TimerScene2 timer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected! Teleporting...");

            congratulationcanvas.SuccessCanvas();
            stoptime.StopTime(false);
            screenTimer.StopTimer();
            timer.StopTimer();
            attempts.SetNumberOfAttempts();
            finalAttempts.updateAttempts();
            retryBtn.SetActive(false);
            proceedBtn.SetActive(true);
            maximumText.SetActive(false);
            evalroom.SetActive(true);
            toDestroy.SetActive(false);
        }
    }


}
