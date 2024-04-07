using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathroomCollider : MonoBehaviour
{
    public BathroomIcon wholehousecheck;
    public GameObject DestroyCollider;
    public AudioClip disableSound; // Sound to play when object is disabled
    public CanvasControllerHTP CanvasControllerHTP;
    public GameObject DestroryPathCollider;
    public GameObject DestroyHint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CanvasControllerHTP.ShowBathRoomAreaCanvas();
            Destroy(DestroryPathCollider);

            wholehousecheck.SetUncheckIconVisible(false);
            wholehousecheck.SetCheckIconVisible(true);
            Destroy(DestroyCollider);
            Destroy(DestroyHint);
            // Play the disable sound
            if (disableSound != null)
            {
                AudioSource.PlayClipAtPoint(disableSound, wholehousecheck.transform.position);
            }
        }

    }
}
