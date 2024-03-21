using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using Meta.WitAi;

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
    public GameObject MobilePhone;
    public GameObject EnergyBar;
    public Canvas Check_list;
    public TaskPercentage bagPercentage;
    private bool canModifyTaskPercentage = true;
    public float taskPercentageCooldown = 1.0f;
    public iconforcannedgood cannedgood;
    public iconforenergybar energybar;
    public iconformoney money;
    public iconforbottledwater bottledwater;
    public iconforclothes clothes;
    public iconforflashlight flashlight;
    public iconformobilephone mobilephone;
    public iconforgatherdessentialgoods gatheredessentialgoods;
    public iconforfirstaidkit firstaidkit;
    public TotalPoints points;


    // for wrist canvas

    public iconforcannedgood wristcannedgood;
    public iconforenergybar wristenergybar;
    public iconformoney wristmoney;
    public iconforbottledwater wristbottledwater;
    public iconforclothes wristclothes;
    public iconforflashlight wristflashlight;
    public iconformobilephone wristmobilephone;
    public iconforfirstaidkit wristfirstaidkit;

    public GameObject HintCanned_good;
    public GameObject HintEnergy_bar;
    public GameObject HintMoney;
    public GameObject HintBottled_water;
    public GameObject HintClothes;
    public GameObject HintFirst_aid_kit;
    public GameObject HintFlashlight;
    public GameObject HintMobilePhone;
    public GameObject HintEnergyBar;

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

                // Check if the bagInventory is empty
                if (itemList.Count == 0)
                {
                    gatheredessentialgoods.SetCheckIconVisible(true);
                    gatheredessentialgoods.SetUncheckIconVisible(false);
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
            wristcannedgood.SetCheckIconVisible(false);
            wristcannedgood.SetUncheckIconVisible(true);
        }

        if (itemName == "Energy bar")
        {
            energybar.SetCheckIconVisible(false);
            energybar.SetUncheckIconVisible(true);
            wristenergybar.SetCheckIconVisible(false);
            wristenergybar.SetUncheckIconVisible(true);
        }

        if (itemName == "Money")
        {
            money.SetCheckIconVisible(false);
            money.SetUncheckIconVisible(true);
            wristmoney.SetCheckIconVisible(false);
            wristmoney.SetUncheckIconVisible(true);
        }

        if (itemName == "Bottled water")
        {
            bottledwater.SetCheckIconVisible(false);
            bottledwater.SetUncheckIconVisible(true);
            wristbottledwater.SetCheckIconVisible(false);
            wristbottledwater.SetUncheckIconVisible(true);
        }

        if (itemName == "Clothes")
        {
            clothes.SetCheckIconVisible(false);
            clothes.SetUncheckIconVisible(true);
            wristclothes.SetCheckIconVisible(false);
            wristclothes.SetUncheckIconVisible(true);
        }

        if (itemName == "Flashlight")
        {
            flashlight.SetCheckIconVisible(false);
            flashlight.SetUncheckIconVisible(true);
            wristflashlight.SetCheckIconVisible(false);
            wristflashlight.SetUncheckIconVisible(true);
        }

        if (itemName == "Mobile Phone")
        {
            mobilephone.SetCheckIconVisible(false);
            mobilephone.SetUncheckIconVisible(true);
            wristmobilephone.SetCheckIconVisible(false);
            wristmobilephone.SetUncheckIconVisible(true);
        }
        

        if (itemName == "First aid kit")
        {
            firstaidkit.SetCheckIconVisible(false);
            firstaidkit.SetUncheckIconVisible(true);
            wristfirstaidkit.SetCheckIconVisible(false);
            wristfirstaidkit.SetUncheckIconVisible(true);
        }



        bagInventory.Add(itemName);
        itemList.Remove(itemName); // Remove the item from the main list

        if (canModifyTaskPercentage)
        {
            StartCoroutine(TaskPercentageCooldown());
            bagPercentage.DecrementTaskPercentage(5);
            points.DecrementPoints(500);
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
        switch (itemName)
        {
            case "Canned good":
                if (HintCanned_good != null)
                {
                    Destroy(HintCanned_good);
                }
                break;
            case "Energy bar":
                if (HintEnergy_bar != null)
                {
                    Destroy(HintEnergy_bar);
                }
                break;
            case "Money":
                if (HintMoney != null)
                {
                    Destroy(HintMoney);
                }
                break;
            case "Bottled water":
                if (HintBottled_water != null)
                {
                    Destroy(HintBottled_water);
                }
                break;
            case "Clothes":
                if (HintClothes != null)
                {
                    Destroy(HintClothes);
                }
                break;
            case "First aid kit":
                if (HintFirst_aid_kit != null)
                {
                    Destroy(HintFirst_aid_kit);
                }
                break;
            case "Flashlight":
                if (HintFlashlight != null)
                {
                    Destroy(HintFlashlight);
                }
                break;
            case "Mobile Phone":
                if (HintMobilePhone != null)
                {
                    Destroy(HintMobilePhone);
                }
                break;
                // Add cases for other items as needed
        }

        if (itemName == "Canned good")
        {
    
            cannedgood.SetCheckIconVisible(true);
            cannedgood.SetUncheckIconVisible(false);
            wristcannedgood.SetCheckIconVisible(true);
            wristcannedgood.SetUncheckIconVisible(false);
        }

        if (itemName == "Energy bar")
        {

            energybar.SetCheckIconVisible(true);
            energybar.SetUncheckIconVisible(false);
            wristenergybar.SetCheckIconVisible(true);
            wristenergybar.SetUncheckIconVisible(false);
        }

        if (itemName == "Money")
        {
        
            money.SetCheckIconVisible(true);
            money.SetUncheckIconVisible(false);
            wristmoney.SetCheckIconVisible(true);
            wristmoney.SetUncheckIconVisible(false);
        }

        if (itemName == "Bottled water")
        {
        
            bottledwater.SetCheckIconVisible(true);
            bottledwater.SetUncheckIconVisible(false);
            wristbottledwater.SetCheckIconVisible(true);
            wristbottledwater.SetUncheckIconVisible(false);
        }

        if (itemName == "Clothes")
        {
     
            clothes.SetCheckIconVisible(true);
            clothes.SetUncheckIconVisible(false);
            wristclothes.SetCheckIconVisible(true);
            wristclothes.SetUncheckIconVisible(false);
        }

        if (itemName == "Flashlight")
        {
       
        
            flashlight.SetCheckIconVisible(true);
            flashlight.SetUncheckIconVisible(false);
            wristflashlight.SetCheckIconVisible(true);
            wristflashlight.SetUncheckIconVisible(false);
        }

        if (itemName == "First aid kit")
        {
         
            firstaidkit.SetCheckIconVisible(true);
            firstaidkit.SetUncheckIconVisible(false);
            wristfirstaidkit.SetCheckIconVisible(true);
            wristfirstaidkit.SetUncheckIconVisible(false);
        }

        if (itemName == "Mobile Phone")
        {
            mobilephone.SetCheckIconVisible(true);
            mobilephone.SetUncheckIconVisible(false);
            wristmobilephone.SetCheckIconVisible(true);
            wristmobilephone.SetUncheckIconVisible(false);
    
        }
        

        bagInventory.Remove(itemName);

        if (canModifyTaskPercentage)
        {
            StartCoroutine(TaskPercentageCooldown());
            bagPercentage.IncrementTaskPercentage(5);
            points.IncrementPoints(500);
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
        Destroy(MobilePhone);
        Destroy(EnergyBar);
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
