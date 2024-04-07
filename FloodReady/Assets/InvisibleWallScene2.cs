using UnityEngine;

public class InvisibleWallScene2 : MonoBehaviour
{
    // Expose the desired position and rotation in the Inspector
    [Header("Teleport Settings")]
    public Vector3 desiredPosition = new Vector3(1.0f, 2.0f, 3.0f);
    public Vector3 desiredRotation = new Vector3(45.0f, 90.0f, 0.0f);
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
        
            //wristwatchStopTime.StopTimer();
            congratulationcanvas.SuccessCanvas();
            stoptime.StopTime(false);
            screenTimer.StopTimer();
            attempts.SetNumberOfAttempts();
            finalAttempts.updateAttempts();
            retryBtn.SetActive(false);
            proceedBtn.SetActive(true);
            maximumText.SetActive(false);
            // Teleport the player to the desired position and rotation
            TeleportPlayer(other.gameObject);
            
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
