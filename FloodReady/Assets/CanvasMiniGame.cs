using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasMiniGame : MonoBehaviour
{
    public GameObject Welcome;
    public GameObject Hallway;
    public GameObject Bedroom;
    public GameObject LivingRoom;
    public GameObject Kitchen;
    public GameObject Bathroom;
    public GameObject CleaningDone;
    public GameObject CleaningFinish;
    public GameObject HallwayChecklist;
    public GameObject BedroomChecklist;
    public GameObject LivingRoomChecklist;
    public GameObject KitchenChecklist;
    public GameObject BathroomChecklist;
    public MessageCanvas messageCanvas;


    void Start()
    {
        Welcome.SetActive(true);
        Hallway.SetActive(false);
        Bedroom.SetActive(false);
        LivingRoom.SetActive(false);
        Kitchen.SetActive(false);
        Bathroom.SetActive(false);
        HallwayChecklist.SetActive(false);
        BedroomChecklist.SetActive(false);
        LivingRoomChecklist.SetActive(false);
        KitchenChecklist.SetActive(false);
        BathroomChecklist.SetActive(false);
        CleaningDone.SetActive(false);
        CleaningFinish.SetActive(false);
    }

    public void showHallway()
    {
        Welcome.SetActive(false);
        Hallway.SetActive(true);
        Bedroom.SetActive(false);
        LivingRoom.SetActive(false);
        Kitchen.SetActive(false);
        Bathroom.SetActive(false);
        HallwayChecklist.SetActive(true);
        BedroomChecklist.SetActive(false);
        LivingRoomChecklist.SetActive(false);
        KitchenChecklist.SetActive(false);
        BathroomChecklist.SetActive(false);
        CleaningDone.SetActive(false);
        CleaningFinish.SetActive(false);

        messageCanvas.OpenCanvasAgain();
    }

    public void showBedroom()
    {
        Welcome.SetActive(false);
        Hallway.SetActive(false);
        Bedroom.SetActive(true);
        LivingRoom.SetActive(false);
        Kitchen.SetActive(false);
        Bathroom.SetActive(false);
        HallwayChecklist.SetActive(false);
        BedroomChecklist.SetActive(true);
        LivingRoomChecklist.SetActive(false);
        KitchenChecklist.SetActive(false);
        BathroomChecklist.SetActive(false);
        CleaningDone.SetActive(false);
        CleaningFinish.SetActive(false);

        messageCanvas.OpenCanvasAgain();
    }

    public void showLivingRoom()
    {
        Welcome.SetActive(false);
        Hallway.SetActive(false);
        Bedroom.SetActive(false);
        LivingRoom.SetActive(true);
        Kitchen.SetActive(false);
        Bathroom.SetActive(false);
        HallwayChecklist.SetActive(false);
        BedroomChecklist.SetActive(false);
        LivingRoomChecklist.SetActive(true);
        KitchenChecklist.SetActive(false);
        BathroomChecklist.SetActive(false);
        CleaningDone.SetActive(false);
        CleaningFinish.SetActive(false);

        messageCanvas.OpenCanvasAgain();
    }

    public void showKitchen()
    {
        Welcome.SetActive(false);
        Hallway.SetActive(false);
        Bedroom.SetActive(false);
        LivingRoom.SetActive(false);
        Kitchen.SetActive(true);
        Bathroom.SetActive(false);
        HallwayChecklist.SetActive(false);
        BedroomChecklist.SetActive(false);
        LivingRoomChecklist.SetActive(false);
        KitchenChecklist.SetActive(true);
        BathroomChecklist.SetActive(false);
        CleaningDone.SetActive(false);
        CleaningFinish.SetActive(false);

        messageCanvas.OpenCanvasAgain();
    }

    public void showBathroom()
    {
        Welcome.SetActive(false);
        Hallway.SetActive(false);
        Bedroom.SetActive(false);
        LivingRoom.SetActive(false);
        Kitchen.SetActive(false);
        Bathroom.SetActive(true);
        HallwayChecklist.SetActive(false);
        BedroomChecklist.SetActive(false);
        LivingRoomChecklist.SetActive(false);
        KitchenChecklist.SetActive(false);
        BathroomChecklist.SetActive(true);
        CleaningDone.SetActive(false);
        CleaningFinish.SetActive(false);

        messageCanvas.OpenCanvasAgain();
    }

    public void showCleaningDone()
    {
        Welcome.SetActive(false);
        Hallway.SetActive(false);
        Bedroom.SetActive(false);
        LivingRoom.SetActive(false);
        Kitchen.SetActive(false);
        Bathroom.SetActive(false);
        HallwayChecklist.SetActive(false);
        BedroomChecklist.SetActive(false);
        LivingRoomChecklist.SetActive(false);
        KitchenChecklist.SetActive(false);
        BathroomChecklist.SetActive(false);
        CleaningDone.SetActive(true);
        CleaningFinish.SetActive(false);

        messageCanvas.OpenCanvasAgain();
    }

    public void showCleaningFinish()
    {
        Welcome.SetActive(false);
        Hallway.SetActive(false);
        Bedroom.SetActive(false);
        LivingRoom.SetActive(false);
        Kitchen.SetActive(false);
        Bathroom.SetActive(false);
        HallwayChecklist.SetActive(false);
        BedroomChecklist.SetActive(false);
        LivingRoomChecklist.SetActive(false);
        KitchenChecklist.SetActive(false);
        BathroomChecklist.SetActive(false);
        CleaningDone.SetActive(false);
        CleaningFinish.SetActive(true);

        messageCanvas.OpenCanvasAgain();
    }

    public void deactivate()
    {
        Welcome.SetActive(false);
        Hallway.SetActive(false);
        Bedroom.SetActive(false);
        LivingRoom.SetActive(false);
        Kitchen.SetActive(false);
        Bathroom.SetActive(false);
        HallwayChecklist.SetActive(false);
        BedroomChecklist.SetActive(false);
        LivingRoomChecklist.SetActive(false);
        KitchenChecklist.SetActive(false);
        BathroomChecklist.SetActive(false);
        CleaningDone.SetActive(false);
        CleaningFinish.SetActive(false);
    }
}
