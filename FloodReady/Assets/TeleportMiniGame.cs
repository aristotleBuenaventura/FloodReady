using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportMiniGame : MonoBehaviour
{
    // Expose the target object in the Inspector
    public Transform targetObject;

    public void LivingRoom(GameObject player)
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
