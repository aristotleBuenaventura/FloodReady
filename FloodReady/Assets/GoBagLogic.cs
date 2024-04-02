using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using Meta.WitAi;

public class GoBagLogic : MonoBehaviour
{
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
    public GoBagItemsCheck checklist;

    // disable go bag
    public GameObject disabledGobag;

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
    bool[] collectedItems = new bool[8]; // Assuming there are 8 items
    private HashSet<string> collectedItemsAll = new HashSet<string>();

    private void Start()
    {
        GoBagClosed.SetActive(false);
        disabledGobag.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        // Check if all items are collected
        bool allItemsCollected = true;
        foreach (bool itemCollected in collectedItems)
        {
            if (!itemCollected)
            {
                allItemsCollected = false;
                break;
            }
        }

        // If all items are collected, display "Completed"
        if (allItemsCollected)
        {
            ShowGoBagCompletedCanvasWithDelay();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        string collidedObjectName = other.gameObject.name;

        if (!collectedItemsAll.Contains(collidedObjectName))
        { 
            switch (collidedObjectName)
            {
            case "Canned good":
                cannedgood.SetCheckIconVisible(false);
                cannedgood.SetUncheckIconVisible(true);
                wristcannedgood.SetCheckIconVisible(false);
                wristcannedgood.SetUncheckIconVisible(true);
                bagPercentage.IncrementTaskPercentage(5);
                points.IncrementPoints(500);
                if (HintCanned_good != null)
                {
                    Destroy(HintCanned_good);
                }
                SetCollectedStatus(0);
                break;
            case "Energy bar":
                energybar.SetCheckIconVisible(false);
                energybar.SetUncheckIconVisible(true);
                wristenergybar.SetCheckIconVisible(false);
                wristenergybar.SetUncheckIconVisible(true);
                bagPercentage.IncrementTaskPercentage(5);
                points.IncrementPoints(500);
                if (HintEnergy_bar != null)
                {
                    Destroy(HintEnergy_bar);
                }
                SetCollectedStatus(1);
                break;
            case "Money":
                money.SetCheckIconVisible(false);
                money.SetUncheckIconVisible(true);
                wristmoney.SetCheckIconVisible(false);
                wristmoney.SetUncheckIconVisible(true);
                bagPercentage.IncrementTaskPercentage(5);
                points.IncrementPoints(500);
                if (HintMoney != null)
                {
                    Destroy(HintMoney);
                }
                SetCollectedStatus(2);
                break;
            case "Bottled water":
                bottledwater.SetCheckIconVisible(false);
                bottledwater.SetUncheckIconVisible(true);
                wristbottledwater.SetCheckIconVisible(false);
                wristbottledwater.SetUncheckIconVisible(true);
                bagPercentage.IncrementTaskPercentage(5);
                points.IncrementPoints(500);
                if (HintBottled_water != null)
                {
                    Destroy(HintBottled_water);
                }
                SetCollectedStatus(3);
                break;
            case "Clothes":
                clothes.SetCheckIconVisible(false);
                clothes.SetUncheckIconVisible(true);
                wristclothes.SetCheckIconVisible(false);
                wristclothes.SetUncheckIconVisible(true);
                bagPercentage.IncrementTaskPercentage(5);
                points.IncrementPoints(500);
                if (HintClothes != null)
                {
                    Destroy(HintClothes);
                }
                SetCollectedStatus(4);
                break;
            case "Flashlight":
                flashlight.SetCheckIconVisible(false);
                flashlight.SetUncheckIconVisible(true);
                wristflashlight.SetCheckIconVisible(false);
                wristflashlight.SetUncheckIconVisible(true);
                bagPercentage.IncrementTaskPercentage(5);
                points.IncrementPoints(500);
                
                if (HintFlashlight != null)
                {
                    Destroy(HintFlashlight);
                }
                SetCollectedStatus(5);
                break;
            case "Mobile Phone":
                mobilephone.SetCheckIconVisible(false);
                mobilephone.SetUncheckIconVisible(true);
                wristmobilephone.SetCheckIconVisible(false);
                wristmobilephone.SetUncheckIconVisible(true);
                bagPercentage.IncrementTaskPercentage(5);
                points.IncrementPoints(500);
                
                if (HintMobilePhone != null)
                {
                    Destroy(HintMobilePhone);
                }
                SetCollectedStatus(6);
                break;
            case "First aid kit":
                firstaidkit.SetCheckIconVisible(false);
                firstaidkit.SetUncheckIconVisible(true);
                wristfirstaidkit.SetCheckIconVisible(false);
                wristfirstaidkit.SetUncheckIconVisible(true);
                bagPercentage.IncrementTaskPercentage(5);
                points.IncrementPoints(500);
                
                if (HintFirst_aid_kit != null)
                {
                    Destroy(HintFirst_aid_kit);
                }
                SetCollectedStatus(7);
                break;
            }
            collectedItemsAll.Add(collidedObjectName);
        }
    }


    void SetCollectedStatus(int index)
    {
        if (index >= 0 && index < collectedItems.Length)
        {
            collectedItems[index] = true;
        }
    }



    // Method to be invoked after a 1-second delay
    private void ShowGoBagCompletedCanvasWithDelay()
    {
        GoBagCompleted.ShowRetrieveGoBagCanvas();
        checklist.SetCheckIconVisible(true);
        checklist.SetUncheckIconVisible(false);
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

}
