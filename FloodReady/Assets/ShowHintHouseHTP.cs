using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHintHouseHTP : MonoBehaviour
{
    public GameObject WashingAreaHint;
    public GameObject LivingAreaHint;
    public GameObject BathRoomHint;
    public GameObject KitchenAreaHint;
    public GameObject SecondFloorHint;
    public GameObject BedRoomHint;
    public GameObject StorageHint;
    public GameObject BalconyHint;
    public GameObject RoofTopHint;


    void Start()
    {

    }
    public void HideAllCanvas()
    {
        WashingAreaHint.SetActive(false);
        LivingAreaHint.SetActive(false);
        BathRoomHint.SetActive(false);
        KitchenAreaHint.SetActive(false);
        SecondFloorHint.SetActive(false);
        BedRoomHint.SetActive(false);
        StorageHint.SetActive(false);
        BalconyHint.SetActive(false);
        RoofTopHint.SetActive(false);
    }


    public void ShowWashingAreaHint()
    {
        WashingAreaHint.SetActive(true);
        LivingAreaHint.SetActive(false);
        BathRoomHint.SetActive(false);
        KitchenAreaHint.SetActive(false);
        SecondFloorHint.SetActive(false);
        BedRoomHint.SetActive(false);
        StorageHint.SetActive(false);
        BalconyHint.SetActive(false);
        RoofTopHint.SetActive(false);
    }

    public void ShowLivingAreaHint()
    {
        WashingAreaHint.SetActive(false);
        LivingAreaHint.SetActive(true);
        BathRoomHint.SetActive(false);
        KitchenAreaHint.SetActive(false);
        SecondFloorHint.SetActive(false);
        BedRoomHint.SetActive(false);
        StorageHint.SetActive(false);
        BalconyHint.SetActive(false);
        RoofTopHint.SetActive(false);
    }

    public void ShowBathRoomHint()
    {
        WashingAreaHint.SetActive(false);
        LivingAreaHint.SetActive(false);
        BathRoomHint.SetActive(true);
        KitchenAreaHint.SetActive(false);
        SecondFloorHint.SetActive(false);
        BedRoomHint.SetActive(false);
        StorageHint.SetActive(false);
        BalconyHint.SetActive(false);
        RoofTopHint.SetActive(false);
    }

    public void ShowKitchenAreaHint()
    {
        WashingAreaHint.SetActive(false);
        LivingAreaHint.SetActive(false);
        BathRoomHint.SetActive(false);
        KitchenAreaHint.SetActive(true);
        SecondFloorHint.SetActive(false);
        BedRoomHint.SetActive(false);
        StorageHint.SetActive(false);
        BalconyHint.SetActive(false);
        RoofTopHint.SetActive(false);
    }

    public void ShowSecondFloorHint()
    {
        WashingAreaHint.SetActive(false);
        LivingAreaHint.SetActive(false);
        BathRoomHint.SetActive(false);
        KitchenAreaHint.SetActive(false);
        SecondFloorHint.SetActive(true);
        BedRoomHint.SetActive(false);
        StorageHint.SetActive(false);
        BalconyHint.SetActive(false);
        RoofTopHint.SetActive(false);
    }

    public void ShowBedRoomHint()
    {
        WashingAreaHint.SetActive(false);
        LivingAreaHint.SetActive(false);
        BathRoomHint.SetActive(false);
        KitchenAreaHint.SetActive(false);
        SecondFloorHint.SetActive(false);
        BedRoomHint.SetActive(true);
        StorageHint.SetActive(false);
        BalconyHint.SetActive(false);
        RoofTopHint.SetActive(false);
    }

    public void ShowStorageHint()
    {
        WashingAreaHint.SetActive(false);
        LivingAreaHint.SetActive(false);
        BathRoomHint.SetActive(false);
        KitchenAreaHint.SetActive(false);
        SecondFloorHint.SetActive(false);
        BedRoomHint.SetActive(false);
        StorageHint.SetActive(true);
        BalconyHint.SetActive(false);
        RoofTopHint.SetActive(false);
    }

    public void ShowBalconyHint()
    {
        WashingAreaHint.SetActive(false);
        LivingAreaHint.SetActive(false);
        BathRoomHint.SetActive(false);
        KitchenAreaHint.SetActive(false);
        SecondFloorHint.SetActive(false);
        BedRoomHint.SetActive(false);
        StorageHint.SetActive(false);
        BalconyHint.SetActive(true);
        RoofTopHint.SetActive(false);
    }

    public void ShowRoofTopHint()
    {
        WashingAreaHint.SetActive(false);
        LivingAreaHint.SetActive(false);
        BathRoomHint.SetActive(false);
        KitchenAreaHint.SetActive(false);
        SecondFloorHint.SetActive(false);
        BedRoomHint.SetActive(false);
        StorageHint.SetActive(false);
        BalconyHint.SetActive(false);
        RoofTopHint.SetActive(true);
    }

}
