using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashingAreaCollider : MonoBehaviour
{
    public WashingRoomIcon wholehousecheck;

    public AudioClip disableSound; // Sound to play when object is disabled
    public CanvasControllerHTP CanvasControllerHTP;
    public GameObject DestroyCollider;
    public GameObject DestroryPathCollider;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag( "Player"))
        {

            wholehousecheck.SetUncheckIconVisible(false);
            wholehousecheck.SetCheckIconVisible(true);

            CanvasControllerHTP.ShowWashingAreaCanvas();
            Destroy(DestroryPathCollider);


            Destroy(DestroyCollider);
            // Play the disable sound
            if (disableSound != null)
            {
                AudioSource.PlayClipAtPoint(disableSound, wholehousecheck.transform.position);
            }
        }

    }
}
