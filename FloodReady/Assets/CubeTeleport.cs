using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTeleport : MonoBehaviour
{
    public teleportMiniGame TP;
    public GameObject player;

    public void TeleportRoom(string room)
    {
        if (room == "Living Room") 
        {
            TP.LivingRoom(player);
        }
    }
}
