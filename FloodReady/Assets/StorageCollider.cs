using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageCollider : MonoBehaviour
{

    public StorageRoomIcon wholehousecheck;
    public GameObject DestroyCollider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            wholehousecheck.SetUncheckIconVisible(false);
            wholehousecheck.SetCheckIconVisible(true);
            Destroy(DestroyCollider);

        }

    }
}
