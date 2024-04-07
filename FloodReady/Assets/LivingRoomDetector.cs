using UnityEngine;

public class LivingRoomDetector : MonoBehaviour
{
    public teleportMiniGame TP; // Corrected class name to "TeleportMiniGame"
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            // Pass the GameObject of the hand to the LivingRoom method
            TP.LivingRoom(player);
        }
    }
}
