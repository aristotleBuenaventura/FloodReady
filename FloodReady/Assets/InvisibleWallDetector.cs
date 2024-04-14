using UnityEngine;

public class InvisibleWallDetector : MonoBehaviour
{
    // Expose the target object in the Inspector
    [Header("Teleport Settings")]
    public Transform targetObject;
    public CanvasController congratulationcanvas;
    public Timer_welldone welldomeStopTime;
    public Timer wristwatchStopTime;
    public ScreenTimer screenTimer;
    public NumberOfAttemptsScene1 attempts;
    public attemptsLeft finalAttempts;
    public GameObject retryBtn;
    public GameObject proceedBtn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected! Teleporting...");
            congratulationcanvas.ShowSuccessCanvas();
            welldomeStopTime.StopTime(false);
            screenTimer.StopTimer();
            attempts.SetNumberOfAttempts();
            finalAttempts.updateAttempts();
            retryBtn.SetActive(false);
            proceedBtn.SetActive(true);
            TeleportPlayer(other.gameObject);
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
