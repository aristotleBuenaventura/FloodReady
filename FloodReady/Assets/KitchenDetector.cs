using UnityEngine;

public class KitchenDetector : MonoBehaviour
{
    // Expose the desired position and rotation in the Inspector
    [Header("Teleport Settings")]
    public Vector3 desiredPosition = new Vector3(1.0f, 2.0f, 3.0f);
    public Vector3 desiredRotation = new Vector3(45.0f, 90.0f, 0.0f);




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            Debug.Log("Player detected! Teleporting...");


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
