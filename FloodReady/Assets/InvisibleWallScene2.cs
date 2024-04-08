using UnityEngine;

public class InvisibleWallScene2 : MonoBehaviour
{
    // Expose the target object in the Inspector
    [Header("Teleport Settings")]
    public Transform targetObject;
    public EscapeCanvasController congratulationcanvas;
    public Timer_welldone stoptime;
    public Timer screenTimer;
    public NumberOfAttemptsScene2 attempts;
    public attemptsLeftScene2 finalAttempts;
    public GameObject retryBtn;
    public GameObject proceedBtn;
    public GameObject maximumText;

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
