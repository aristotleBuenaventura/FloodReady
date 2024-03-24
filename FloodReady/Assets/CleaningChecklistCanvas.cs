using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleaningChecklistCanvas : MonoBehaviour
{
    public GameObject LivingRoom;
    public GameObject Bathroom;
    public GameObject Kitchen;
    public GameObject Bedroom;
    public GameObject Hallway;
    public GameObject ChecklistCanvas;
    public GameObject WaterNozzle;
    public GameObject clothes;
    // Start is called before the first frame update
    void Start()
    {
        LivingRoom.SetActive(false);
        Bathroom.SetActive(false);
        Kitchen.SetActive(false);
        Bedroom.SetActive(false);
        Hallway.SetActive(false);
    }

    public void ShowLivingRoomCanvas()
    {
        LivingRoom.SetActive(true);
        Bathroom.SetActive(false);
        Kitchen.SetActive(false);
        Bedroom.SetActive(false);
        Hallway.SetActive(false);
    }


    public void ShowKitchenCanvas()
    {
        LivingRoom.SetActive(false);
        Bathroom.SetActive(false);
        Kitchen.SetActive(true);
        Bedroom.SetActive(false);
        Hallway.SetActive(false);
    }

    

    public void ShowHallwayCanvas()
    {
        LivingRoom.SetActive(false);
        Bathroom.SetActive(false);
        Kitchen.SetActive(false);
        Bedroom.SetActive(false);
        Hallway.SetActive(true);
    }

    public void ShowBedRoomCanvas()
    {
        LivingRoom.SetActive(false);
        Bathroom.SetActive(false);
        Kitchen.SetActive(false);
        Bedroom.SetActive(true);
        Hallway.SetActive(false);
    }


    public void ShowBathRoomCanvas()
    {
        LivingRoom.SetActive(false);
        Bathroom.SetActive(true);
        Kitchen.SetActive(false);
        Bedroom.SetActive(false);
        Hallway.SetActive(false);
    }

    public void ShowGatherClothesCanvas()
    {
        LivingRoom.SetActive(false);
        Bathroom.SetActive(false);
        Kitchen.SetActive(false);
        Bedroom.SetActive(false);
        Hallway.SetActive(false);
        clothes.SetActive(true);
    }

    public void deactivate()
    {
        LivingRoom.SetActive(false);
        Bathroom.SetActive(false);
        Kitchen.SetActive(false);
        Bedroom.SetActive(false);
        Hallway.SetActive(false);
        clothes.SetActive(false);

        //Destroy(ChecklistCanvas);
        Destroy(WaterNozzle);
    }
}
