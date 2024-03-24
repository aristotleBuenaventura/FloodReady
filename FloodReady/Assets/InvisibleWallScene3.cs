using UnityEngine;

public class InvisibleWallScene3 : MonoBehaviour
{
    // Expose the desired position and rotation in the Inspector
    [Header("Teleport Settings")]
    public Vector3 desiredPosition = new Vector3(1.0f, 2.0f, 3.0f);
    public Vector3 desiredRotation = new Vector3(45.0f, 90.0f, 0.0f);
    public RecoveryCanvasController congratulationcanvas;
    public Timer_welldone stoptime;
    public Timer screenTimer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TeleportPlayer(other.gameObject);
            Debug.Log("Player detected! Teleporting...");
            screenTimer.StopTimer();
            //wristwatchStopTime.StopTimer();
            congratulationcanvas.SuccessCanvas();
            stoptime.StopTime();
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
