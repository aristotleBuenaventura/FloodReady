using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class InventoryManager : MonoBehaviour
{
    
    // Detect collision and remove items from the bag's inventory array
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "canned_goods")
        {
            Destroy(col.gameObject);
        }
    }

}
