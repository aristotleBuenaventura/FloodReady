using UnityEngine;

public class InvisibleWallScene3 : MonoBehaviour
{
    // Expose the target object in the Inspector
    [Header("Teleport Settings")]
    public Transform targetObject;
    public RecoveryCanvasController congratulationcanvas;
    public Timer_welldone stoptime;
    public ScreenTimer screenTimer;
    public NumberOfAttemptsScene3 attempts;
    public attemptsLeftScene3 finalAttempts;
    public GameObject retryBtn;
    public GameObject proceedBtn;
    public GameObject limit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TeleportPlayer(other.gameObject);
            Debug.Log("Player detected! Teleporting...");
            screenTimer.StopTimer();
            attempts.SetNumberOfAttempts();
            finalAttempts.updateAttempts();
            congratulationcanvas.SuccessCanvas();
            stoptime.StopTime(false);
            retryBtn.SetActive(false);
            limit.SetActive(false);
            proceedBtn.SetActive(true);
        }
    }

    private void TeleportPlayer(GameObject player)
    {
        if (player != null && targetObject != null)
        {
            // Copy the world transform of the target object
            Transform targetTransform = targetObject.transform;

            // Paste the world transform to the player
            player.transform.position = targetTransform.position;
            player.transform.rotation = targetTransform.rotation;
        }
    }
}
