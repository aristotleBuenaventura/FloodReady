using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomCollider : MonoBehaviour
{

    public BedroomIcon wholehousecheck;
    public GameObject DestroyCollider;
    public AudioClip disableSound; // Sound to play when object is disabled
    public CanvasControllerHTP CanvasControllerHTP;
    public GameObject DestroryPathCollider;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CanvasControllerHTP.ShowBedroomAreaCanvas();
            Destroy(DestroryPathCollider);
            Destroy(DestroryPathCollider);
            wholehousecheck.SetUncheckIconVisible(false);
            wholehousecheck.SetCheckIconVisible(true);
            Destroy(DestroyCollider);
            // Play the disable sound
            if (disableSound != null)
            {
                AudioSource.PlayClipAtPoint(disableSound, wholehousecheck.transform.position);
            }
        }

    }
}
