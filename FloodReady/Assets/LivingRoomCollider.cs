using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingRoomCollider : MonoBehaviour
{
   public LivingRoomIcon wholehousecheck;
    public GameObject DestroyCollider;
    public AudioClip disableSound; // Sound to play when object is disabled
    public CanvasControllerHTP CanvasControllerHTP;
    public GameObject DestroryPathCollider;
    public GameObject DestroyHint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CanvasControllerHTP.ShowLivingRoomAreaCanvas();
            wholehousecheck.SetUncheckIconVisible(false);
            wholehousecheck.SetCheckIconVisible(true);
            Destroy(DestroyCollider);
            Destroy(DestroryPathCollider);
            Destroy(DestroyHint);
            // Play the disable sound
            if (disableSound != null)
            {
                AudioSource.PlayClipAtPoint(disableSound, wholehousecheck.transform.position);
            }
        }

    }
}
