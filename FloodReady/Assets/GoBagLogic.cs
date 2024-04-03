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
    public GameObject disabledGobag;
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


    void Update()
    {
        bool allItemsCollected = true;
        foreach (bool itemCollected in collectedItems)
        {
            if (!itemCollected)
            {
                allItemsCollected = false;
                break;
            }
        }


        if (allItemsCollected)
        {
            StartCoroutine(DisappearWithDelay());
        }
    }

    IEnumerator DisappearWithDelay()
    {
        yield return new WaitForSeconds(2f);
        ShowGoBagCompletedCanvasWithDelay();

    }

    void OnTriggerExit(Collider other)
    {
        string collidedObjectName = other.gameObject.name;

        if (!collectedItemsAll.Contains(collidedObjectName))
        { 
            switch (collidedObjectName)
            {
            case "Canned good":
                bagPercentage.IncrementTaskPercentage(5);
                points.IncrementPoints(500);
                cannedgood.SetCheckIconVisible(true);
                cannedgood.SetUncheckIconVisible(false);
                wristcannedgood.SetCheckIconVisible(true);
                wristcannedgood.SetUncheckIconVisible(false);
                if (HintCanned_good != null)
                {
                    Destroy(HintCanned_good);
                }
                SetCollectedStatus(0);
                break;
            case "Energy bar":
                bagPercentage.IncrementTaskPercentage(5);
                points.IncrementPoints(500);
                energybar.SetCheckIconVisible(true);
                energybar.SetUncheckIconVisible(false);
                wristenergybar.SetCheckIconVisible(true);
                wristenergybar.SetUncheckIconVisible(false);
                if (HintEnergy_bar != null)
                {
                    Destroy(HintEnergy_bar);
                }
                SetCollectedStatus(1);
                break;
            case "Money":
                bagPercentage.IncrementTaskPercentage(5);
                points.IncrementPoints(500);
                money.SetCheckIconVisible(true);
                money.SetUncheckIconVisible(false);
                wristmoney.SetCheckIconVisible(true);
                wristmoney.SetUncheckIconVisible(false);
                if (HintMoney != null)
                {
                    Destroy(HintMoney);
                }
                SetCollectedStatus(2);
                break;
            case "Bottled water":
                bagPercentage.IncrementTaskPercentage(5);
                points.IncrementPoints(500);
                bottledwater.SetCheckIconVisible(true);
                bottledwater.SetUncheckIconVisible(false);
                wristbottledwater.SetCheckIconVisible(true);
                wristbottledwater.SetUncheckIconVisible(false);
                if (HintBottled_water != null)
                {
                    Destroy(HintBottled_water);
                }
                SetCollectedStatus(3);
                break;
            case "Clothes":
                bagPercentage.IncrementTaskPercentage(5);
                points.IncrementPoints(500);
                clothes.SetCheckIconVisible(true);
                clothes.SetUncheckIconVisible(false);
                wristclothes.SetCheckIconVisible(true);
                wristclothes.SetUncheckIconVisible(false);
                if (HintClothes != null)
                {
                    Destroy(HintClothes);
                }
                SetCollectedStatus(4);
                break;
            case "Flashlight":
                bagPercentage.IncrementTaskPercentage(5);
                points.IncrementPoints(500);
                flashlight.SetCheckIconVisible(true);
                flashlight.SetUncheckIconVisible(false);
                wristflashlight.SetCheckIconVisible(true);
                wristflashlight.SetUncheckIconVisible(false);
                if (HintFlashlight != null)
                {
                    Destroy(HintFlashlight);
                }
                SetCollectedStatus(5);
                break;
            case "Mobile Phone":
                bagPercentage.IncrementTaskPercentage(5);
                points.IncrementPoints(500);
                mobilephone.SetCheckIconVisible(true);
                mobilephone.SetUncheckIconVisible(false);
                wristmobilephone.SetCheckIconVisible(true);
                wristmobilephone.SetUncheckIconVisible(false);
                if (HintMobilePhone != null)
                {
                    Destroy(HintMobilePhone);
                }
                SetCollectedStatus(6);
                break;
            case "First aid kit":
                bagPercentage.IncrementTaskPercentage(5);
                points.IncrementPoints(500);
                firstaidkit.SetCheckIconVisible(true);
                firstaidkit.SetUncheckIconVisible(false);
                wristfirstaidkit.SetCheckIconVisible(true);
                wristfirstaidkit.SetUncheckIconVisible(false);
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
