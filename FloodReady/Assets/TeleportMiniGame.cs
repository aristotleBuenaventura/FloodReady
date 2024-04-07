using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportMiniGame : MonoBehaviour
{
    // Expose the desired position and rotation in the Inspector
    private Vector3 desiredPosition;
    private Vector3 desiredRotation;
  


    public void LivingRoom(GameObject player)
    {
        if (player != null)
        {
            desiredPosition = new Vector3(-1.235f, 2.22f, -2.919f);
            desiredRotation = new Vector3(0f, 231.814f, 0.0f);
            // Set the desired position from the Inspector
            player.transform.position = desiredPosition;

            // Set the desired rotation from the Inspector
            player.transform.rotation = Quaternion.Euler(desiredRotation);


        }
    }


}
