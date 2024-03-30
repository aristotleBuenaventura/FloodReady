
using UnityEngine;

public class BathroomTeleport : MonoBehaviour
{
    // Expose the desired position and rotation in the Inspector
    public Vector3 desiredPosition;
    public Vector3 desiredRotation;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
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
