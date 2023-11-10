using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class InventoryManager : MonoBehaviour
{
    public List<string> itemList = new List<string>();
    public List<string> bagInventory = new List<string>();
    public List<string> validItemNames = new List<string>() { "Canned good", "Energy bar", "Money", "Bottled water", "Clothes", "First aid kit", "Flashlight" };
    private bool canAddToBag = true;
    public CanvasController GoBagCompleted;


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
                    StartCoroutine(RemoveAndAddBackItem(collidedObjectName, 1.0f)); // Adjust the delay time as needed
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

    private IEnumerator RemoveAndAddBackItem(string itemName, float delay)
    {
        yield return new WaitForSeconds(delay);
        RemoveItemFromBag(itemName);
        AddItemBackToList(itemName);
    }

    private void RemoveItemFromBag(string itemName)
    {
        bagInventory.Remove(itemName);
        if (bagInventory == null || bagInventory.Count == 0)
        {
            // Assuming messageCanvas is an instance of some class that has the ShowGoBagCompletedCanvas method
            GoBagCompleted.ShowGoBagCompletedCanvas();
            Debug.Log("go bag completed");
        }
    }

    private void AddItemBackToList(string itemName)
    {
        itemList.Add(itemName);
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
