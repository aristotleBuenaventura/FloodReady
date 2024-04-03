using UnityEngine;

public class InvisibleWallScene3 : MonoBehaviour
{
    // Expose the desired position and rotation in the Inspector
    [Header("Teleport Settings")]
    public Vector3 desiredPosition;
    public Vector3 desiredRotation;
    public RecoveryCanvasController congratulationcanvas;
    public Timer_welldone stoptime;
    public Timer screenTimer;
    public NumberOfAttemptsScene3 attempts;
    public attemptsLeftScene3 finalAttempts;
    public GameObject retryBtn;
    public GameObject proceedBtn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TeleportPlayer(other.gameObject);
            Debug.Log("Player detected! Teleporting...");
            screenTimer.StopTimer();
            attempts.SetNumberOfAttempts();
            finalAttempts.updateAttempts();
            //wristwatchStopTime.StopTimer();
            congratulationcanvas.SuccessCanvas();
            stoptime.StopTime(false);
            retryBtn.SetActive(false);
            proceedBtn.SetActive(true);
            // Teleport the player to the desired position and rotation


        }
    }

    private void TeleportPlayer(GameObject player)
    {
        if (player != null)
        {

            // Set the desired position from the Inspector
            player.transform.position = desiredPosition;

            // Set the desired rotation from the Inspector
            player.transform.rotation = Quaternion.Euler(desiredRotation);


        }
    }
}
