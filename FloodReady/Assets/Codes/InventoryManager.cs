using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class InventoryManager : MonoBehaviour
{
    public List<string> itemList = new List<string>();
    public List<string> bagInventory = new List<string>();
    public List<string> validItemNames = new List<string>() { "Canned good", "Energy bar", "Money", "Bottled water", "Clothes", "First aid kit", "Flashlight", "Mobile Phone" };
    private bool canAddToBag = true;
    public CanvasController GoBagCompleted;
    public GameObject GoBag;
    public GameObject GoBagClosed;
    public GameObject Canned_good;
    public GameObject Energy_bar;
    public GameObject Money;
    public GameObject Bottled_water;
    public GameObject Clothes;
    public GameObject First_aid_kit;
    public GameObject Flashlight;
    public Canvas Check_list;
    public TaskPercentage bagPercentage;
    private bool canModifyTaskPercentage = true;
    public float taskPercentageCooldown = 1.0f;
    public iconforcannedgood cannedgood;

    private void Start()
    {
        GoBagClosed.SetActive(false);
    }

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

                    // Call SetCheckIconVisible when Canned_good is added to the bag
                    
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
        if (itemName == "Canned good")
        {
            cannedgood.SetCheckIconVisible(false);
            cannedgood.SetUncheckIconVisible(true);
        }



        bagInventory.Add(itemName);
        itemList.Remove(itemName); // Remove the item from the main list

        if (canModifyTaskPercentage)
        {
            StartCoroutine(TaskPercentageCooldown());
            bagPercentage.DecrementTaskPercentage(5);
        }

        
    }

    private IEnumerator RemoveAndAddBackItem(string itemName, float delay)
    {
        yield return new WaitForSeconds(delay);

        RemoveItemFromBag(itemName);
        AddItemBackToList(itemName);
    }

    private void RemoveItemFromBag(string itemName)
    {
        if (itemName == "Canned good")
        {
            cannedgood.SetCheckIconVisible(true);
            cannedgood.SetUncheckIconVisible(false);
        }

        bagInventory.Remove(itemName);

        if (canModifyTaskPercentage)
        {
            StartCoroutine(TaskPercentageCooldown());
            bagPercentage.IncrementTaskPercentage(5);
        }

        if (bagInventory == null || bagInventory.Count == 0)
        {
            // Invoke the method with a delay of 1 second
            Invoke("ShowGoBagCompletedCanvasWithDelay", 1f);
        }

    }

    private IEnumerator TaskPercentageCooldown()
    {
        canModifyTaskPercentage = false;
        yield return new WaitForSeconds(taskPercentageCooldown);
        canModifyTaskPercentage = true;
    }

    // Method to be invoked after a 1-second delay
    private void ShowGoBagCompletedCanvasWithDelay()
    {
        // Assuming GoBagCompleted is an instance of some class that has the ShowRetrieveGoBagCanvas method
        GoBagCompleted.ShowRetrieveGoBagCanvas();

        // Assuming GoBag, Canned_good, Energy_bar, Money, Bottled_water, Clothes, First_aid_kit,
        // Flashlight, Check_list are GameObjects that you want to destroy
        Destroy(GoBag);
        Destroy(Canned_good);
        Destroy(Energy_bar);
        Destroy(Money);
        Destroy(Bottled_water);
        Destroy(Clothes);
        Destroy(First_aid_kit);
        Destroy(Flashlight);
        Destroy(Check_list);
        GoBagClosed.SetActive(true);

        Debug.Log("go bag completed");
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
