using UnityEngine;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    public List<string> itemList = new List<string>();
    public string[] bagInventory = new string[7] { "Canned good", "Energy bar", "Money", "Bottled water", "Clothes", "First aid kit", "Flashlight" };
    public List<string> validItemNames = new List<string>() { "Canned good", "Energy bar", "Money", "Bottled water", "Clothes", "First aid kit", "Flashlight"};
    private bool canAddToBag = true;

    void OnTriggerEnter(Collider other)
    {
        string collidedObjectName = other.gameObject.name;

        if (canAddToBag && validItemNames.Contains(collidedObjectName) && !IsItemInBag(collidedObjectName))
        {
            AddItemToBag(collidedObjectName);
            Debug.Log("Item added to the bag: " + collidedObjectName);
        }
    }

    /*void OnTriggerExit(Collider other)
    {
        string collidedObjectName = other.gameObject.name;

        Debug.Log("Trigger exit: " + collidedObjectName);

        if (validItemNames.Contains(collidedObjectName) && IsItemInBag(collidedObjectName))
        {
            RemoveItemFromBag(collidedObjectName);
            Debug.Log("Item removed from the bag: " + collidedObjectName);
        }
    }*/

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

    private void RemoveItemFromBag(string itemName)
    {
        for (int i = 0; i < bagInventory.Length; i++)
        {
            if (bagInventory[i] == itemName)
            {
                bagInventory[i] = null;
                break;
            }
        }
    }

    private bool IsItemInBag(string itemName)
    {
        return System.Array.IndexOf(bagInventory, itemName) >= 0;
    }

    public void EnableAddingToBag()
    {
        canAddToBag = true;
    }

    public void DisableAddingToBag()
    {
        canAddToBag = false;
    }
}
