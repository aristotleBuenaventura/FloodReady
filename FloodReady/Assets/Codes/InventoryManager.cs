using UnityEngine;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    public List<string> itemList = new List<string>();
    public string[] bagInventory = new string[10] { "Canned good", "Money", "Bottled water", "First aid kit", null, null, null, null, null, null };

    // Detect collision and remove items from the bag's inventory array
    void OnCollisionEnter(Collision collision)
    {
        string collidedObjectName = collision.gameObject.name;

        if (collidedObjectName == "Canned good" || collidedObjectName == "Money" || collidedObjectName == "Bottled water" || collidedObjectName == "First aid kit")
        {
            // Find the index of the collided item in the bag's inventory
            int itemIndex = System.Array.IndexOf(bagInventory, collidedObjectName);

            if (itemIndex >= 0)
            {
                bagInventory[itemIndex] = null;

                // Print the name of the collided asset to the console
                Debug.Log("Collided with: " + collidedObjectName);
            }
        }
    }
}