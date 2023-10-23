using UnityEngine;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    public List<string> itemList = new List<string>();
    public string[] bagInventory = new string[10] { "Canned good", "Money", "Bottled water", "First aid kit", null, null, null, null, null, null };

    // Use Trigger events for detecting items entering and exiting the trigger zone
    void OnTriggerEnter(Collider other)
    {
        string collidedObjectName = other.gameObject.name;

        if (IsItemInBag(collidedObjectName))
        {
            RemoveItemFromBag(collidedObjectName);
            Debug.Log("Item removed from the bag: " + collidedObjectName);
        }
    }

    void OnTriggerExit(Collider other)
    {
        string collidedObjectName = other.gameObject.name;

        if (IsItemInBag(collidedObjectName))
        {
            AddItemToBag(collidedObjectName);
            Debug.Log("Item added to the bag: " + collidedObjectName);
        }
    }

    // Helper functions to check if an item is in the bag's inventory
    private bool IsItemInBag(string itemName)
    {
        return System.Array.IndexOf(bagInventory, itemName) >= 0;
    }

    private void RemoveItemFromBag(string itemName)
    {
        int itemIndex = System.Array.IndexOf(bagInventory, itemName);
        if (itemIndex >= 0)
        {
            bagInventory[itemIndex] = null;
        }
    }

    private void AddItemToBag(string itemName)
    {
        for (int i = 0; i < bagInventory.Length; i++)
        {
            if (bagInventory[i] == null)
            {
                bagInventory[i] = itemName;
                break;
            }
        }
    }
}
