using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasControllerHTP : MonoBehaviour
{
    public GameObject welcomeCanvas;
    public GameObject WashingArea;
    public GameObject LivingRoomArea;
    public GameObject BathRoomArea;
    public GameObject KitchenArea;
    public GameObject HallwayArea;
    public GameObject BedroomArea;
    public GameObject StorageRoomArea;
    public GameObject BalconyArea;
    public GameObject ProoceedSceneArea;
    public GameObject OpenChecklist;
    public MessageCanvas messageCanvas;


    private void Start()
    {
    }

    public void ShowWelcomeCanvas()
    {
        welcomeCanvas.SetActive(true);
        OpenChecklist.SetActive(false);
        WashingArea.SetActive(false);
        LivingRoomArea.SetActive(false);
        BathRoomArea.SetActive(false);
        KitchenArea.SetActive(false);
        HallwayArea.SetActive(false);
        BedroomArea.SetActive(false);
        StorageRoomArea.SetActive(false);
        BalconyArea.SetActive(false);
        ProoceedSceneArea.SetActive(false);
    }


    public void OpenChecklistCanvas()
    {
        welcomeCanvas.SetActive(false);
        OpenChecklist.SetActive(true);
        WashingArea.SetActive(false);
        LivingRoomArea.SetActive(false);
        BathRoomArea.SetActive(false);
        KitchenArea.SetActive(false);
        HallwayArea.SetActive(false);
        BedroomArea.SetActive(false);
        StorageRoomArea.SetActive(false);
        BalconyArea.SetActive(false);
        ProoceedSceneArea.SetActive(false);
    }

    public void ShowWashingAreaCanvas()
    {
        welcomeCanvas.SetActive(false);
        WashingArea.SetActive(true);
        LivingRoomArea.SetActive(false);
        BathRoomArea.SetActive(false);
        KitchenArea.SetActive(false);
        HallwayArea.SetActive(false);
        BedroomArea.SetActive(false);
        StorageRoomArea.SetActive(false);
        BalconyArea.SetActive(false);
        ProoceedSceneArea.SetActive(false);
        messageCanvas.OpenCanvasAgain();
        OpenChecklist.SetActive(false);
    }

    public void ShowLivingRoomAreaCanvas()
    {
        welcomeCanvas.SetActive(false);
        WashingArea.SetActive(false);
        LivingRoomArea.SetActive(true);
        BathRoomArea.SetActive(false);
        KitchenArea.SetActive(false);
        HallwayArea.SetActive(false);
        BedroomArea.SetActive(false);
        StorageRoomArea.SetActive(false);
        BalconyArea.SetActive(false);
        ProoceedSceneArea.SetActive(false);
        messageCanvas.OpenCanvasAgain();
        OpenChecklist.SetActive(false);
    }

    public void ShowBathRoomAreaCanvas()
    {
        welcomeCanvas.SetActive(false);
        WashingArea.SetActive(false);
        LivingRoomArea.SetActive(false);
        BathRoomArea.SetActive(true);
        KitchenArea.SetActive(false);
        HallwayArea.SetActive(false);
        BedroomArea.SetActive(false);
        StorageRoomArea.SetActive(false);
        BalconyArea.SetActive(false);
        ProoceedSceneArea.SetActive(false);
        messageCanvas.OpenCanvasAgain();
        OpenChecklist.SetActive(false);
    }

    public void ShowKitchenAreaCanvas()
    {
        welcomeCanvas.SetActive(false);
        WashingArea.SetActive(false);
        LivingRoomArea.SetActive(false);
        BathRoomArea.SetActive(false);
        KitchenArea.SetActive(true);
        HallwayArea.SetActive(false);
        BedroomArea.SetActive(false);
        StorageRoomArea.SetActive(false);
        BalconyArea.SetActive(false);
        ProoceedSceneArea.SetActive(false);
        messageCanvas.OpenCanvasAgain();
        OpenChecklist.SetActive(false);
    }

    public void ShowHallwayAreaCanvas()
    {
        welcomeCanvas.SetActive(false);
        WashingArea.SetActive(false);
        LivingRoomArea.SetActive(false);
        BathRoomArea.SetActive(false);
        KitchenArea.SetActive(false);
        HallwayArea.SetActive(true);
        BedroomArea.SetActive(false);
        StorageRoomArea.SetActive(false);
        BalconyArea.SetActive(false);
        ProoceedSceneArea.SetActive(false);
        messageCanvas.OpenCanvasAgain();
        OpenChecklist.SetActive(false);
    }

    public void ShowBedroomAreaCanvas()
    {
        welcomeCanvas.SetActive(false);
        WashingArea.SetActive(false);
        LivingRoomArea.SetActive(false);
        BathRoomArea.SetActive(false);
        KitchenArea.SetActive(false);
        HallwayArea.SetActive(false);
        BedroomArea.SetActive(true);
        StorageRoomArea.SetActive(false);
        BalconyArea.SetActive(false);
        ProoceedSceneArea.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    public void ShowStorageRoomAreaCanvas()
    {
        welcomeCanvas.SetActive(false);
        WashingArea.SetActive(false);
        LivingRoomArea.SetActive(false);
        BathRoomArea.SetActive(false);
        KitchenArea.SetActive(false);
        HallwayArea.SetActive(false);
        BedroomArea.SetActive(false);
        StorageRoomArea.SetActive(true);
        BalconyArea.SetActive(false);
        ProoceedSceneArea.SetActive(false);
        messageCanvas.OpenCanvasAgain();
        OpenChecklist.SetActive(false);
    }

    public void ShowBalconyAreaCanvas()
    {
        welcomeCanvas.SetActive(false);
        WashingArea.SetActive(false);
        LivingRoomArea.SetActive(false);
        BathRoomArea.SetActive(false);
        KitchenArea.SetActive(false);
        HallwayArea.SetActive(false);
        BedroomArea.SetActive(false);
        StorageRoomArea.SetActive(false);
        BalconyArea.SetActive(true);
        ProoceedSceneArea.SetActive(false);
        messageCanvas.OpenCanvasAgain();
        OpenChecklist.SetActive(false);
    }

    public void ShowProoceedSceneAreaCanvas()
    {
        welcomeCanvas.SetActive(false);
        WashingArea.SetActive(false);
        LivingRoomArea.SetActive(false);
        BathRoomArea.SetActive(false);
        KitchenArea.SetActive(false);
        HallwayArea.SetActive(false);
        BedroomArea.SetActive(false);
        StorageRoomArea.SetActive(false);
        BalconyArea.SetActive(false);
        ProoceedSceneArea.SetActive(true);
        messageCanvas.OpenCanvasAgain();
        OpenChecklist.SetActive(false);
    }

    public void HideAllCanvas()
    {
        welcomeCanvas.SetActive(false);
        WashingArea.SetActive(false);
        LivingRoomArea.SetActive(false);
        BathRoomArea.SetActive(false);
        KitchenArea.SetActive(false);
        HallwayArea.SetActive(false);
        BedroomArea.SetActive(false);
        StorageRoomArea.SetActive(false);
        BalconyArea.SetActive(false);
        ProoceedSceneArea.SetActive(false);
        OpenChecklist.SetActive(false);
    }
}
