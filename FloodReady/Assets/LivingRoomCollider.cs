using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingRoomCollider : MonoBehaviour
{
   public LivingRoomIcon wholehousecheck;
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
