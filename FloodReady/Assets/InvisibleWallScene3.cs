using UnityEngine;
using System.Collections;

public class InvisibleWallScene3 : MonoBehaviour
{
    // Expose the target object in the Inspector
    [Header("Teleport Settings")]
    public RecoveryCanvasController congratulationcanvas;
    public Timer_welldone_3 stoptime;
    public ScreenTimer screenTimer;
    public NumberOfAttemptsScene3 attempts;
    public attemptsLeftScene3 finalAttempts;
    public GameObject retryBtn;
    public GameObject proceedBtn;
    public GameObject limit;
    public GameObject evalroom;
    public GameObject objecttodestroy;
    public TimerScene3 timer;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected! Teleporting...");
            screenTimer.StopTimer();
            timer.StopTimer();
            attempts.SetNumberOfAttempts();
            finalAttempts.updateAttempts();
            congratulationcanvas.SuccessCanvas();
            stoptime.StopTime(false);
            retryBtn.SetActive(false);
            limit.SetActive(false);
            proceedBtn.SetActive(true);
            objecttodestroy.SetActive(false);
            evalroom.SetActive(true);
        }
    }


}
