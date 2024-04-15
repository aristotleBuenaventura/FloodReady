using UnityEngine;

public class InvisibleWallScene2 : MonoBehaviour
{
    // Expose the target object in the Inspector
    [Header("Teleport Settings")]
    public Transform targetObject;
    public EscapeCanvasController congratulationcanvas;
    public Timer_welldone stoptime;
    public ScreenTimer screenTimer;
    public NumberOfAttemptsScene2 attempts;
    public attemptsLeftScene2 finalAttempts;
    public GameObject retryBtn;
    public GameObject proceedBtn;
    public GameObject maximumText;
    public GameObject playerOVR;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected! Teleporting...");

            congratulationcanvas.SuccessCanvas();
            stoptime.StopTime(false);
            screenTimer.StopTimer();
            attempts.SetNumberOfAttempts();
            finalAttempts.updateAttempts();
            retryBtn.SetActive(false);
            proceedBtn.SetActive(true);
            maximumText.SetActive(false);

            // Teleport the player by copying the world transform of the target object
            TeleportPlayer();
        }
    }

    private void TeleportPlayer()
    {
        if (playerOVR != null && targetObject != null)
        {
            // Copy the world transform of the target object
            Transform targetTransform = targetObject.transform;

            // Paste the world transform to the player
            playerOVR.transform.position = targetTransform.position;
            playerOVR.transform.rotation = targetTransform.rotation;
        }
    }
}
