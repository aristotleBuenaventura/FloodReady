using UnityEngine;

public class KitchenDetector : MonoBehaviour
{
    // Expose the desired position and rotation in the Inspector
    [Header("Teleport Settings")]
    public Vector3 desiredPosition = new Vector3(1.0f, 2.0f, 3.0f);
    public Vector3 desiredRotation = new Vector3(45.0f, 90.0f, 0.0f);
    public GameObject Player;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            Debug.Log("Player detected! Teleporting...");


            TeleportPlayer();
        }
    }

    private void TeleportPlayer()
    {
        if (Player != null)
        {

            // Set the desired position from the Inspector
            Player.transform.position = desiredPosition;

            // Set the desired rotation from the Inspector
            Player.transform.rotation = Quaternion.Euler(desiredRotation);


        }
    }
}
