using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofTopCollider : MonoBehaviour
{



    public RooftopIcon wholehousecheck;
    public GameObject DestroyCollider;
    public AudioClip disableSound; // Sound to play when object is disabled
    public CanvasControllerHTP CanvasControllerHTP;
    public GameObject DestroyHint;

    public GameObject ThreePortals;
    private void Start()
    {
        ThreePortals.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CanvasControllerHTP.ShowProoceedSceneAreaCanvas();
  
            wholehousecheck.SetUncheckIconVisible(false);
            wholehousecheck.SetCheckIconVisible(true);
            Destroy(DestroyHint);
            Destroy(DestroyCollider);
            ThreePortals.SetActive(true);
            // Play the disable sound
            if (disableSound != null)
            {
                AudioSource.PlayClipAtPoint(disableSound, wholehousecheck.transform.position);
            }
        }

    }
}
