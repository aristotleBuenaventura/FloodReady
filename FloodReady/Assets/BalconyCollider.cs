using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class BalconyCollider : MonoBehaviour
{
    public BalconyIcon wholehousecheck;
    public GameObject DestroyCollider;
    public AudioClip disableSound; // Sound to play when object is disabled

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

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
