using UnityEngine;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    public List<string> itemList = new List<string>();
    public List<string> bagInventory = new List<string>();
    public List<string> validItemNames = new List<string>() { "Canned good", "Energy bar", "Money", "Bottled water", "Clothes", "First aid kit", "Flashlight" };
    private bool canAddToBag = true;

    void OnTriggerEnter(Collider other)
    {
        string collidedObjectName = other.gameObject.name;

        if (canAddToBag)
        {
            if (validItemNames.Contains(collidedObjectName))
            {
                if (!IsItemInBag(collidedObjectName))
                {
                    AddItemToBag(collidedObjectName);
                    Debug.Log("Item added to the bag: " + collidedObjectName);
                }
                else
                {
                    RemoveItemFromBag(collidedObjectName);
                    Debug.Log("Item removed from the bag: " + collidedObjectName);
                }
            }
        }
    }

    private void AddItemToBag(string itemName)
    {
        bagInventory.Add(itemName);
        itemList.Remove(itemName); // Remove the item from the main list
    }

    private void RemoveItemFromBag(string itemName)
    {
        bagInventory.Remove(itemName);
        itemList.Add(itemName); // Add the item back to the main list
    }

    private bool IsItemInBag(string itemName)
    {
        return bagInventory.Contains(itemName);
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
