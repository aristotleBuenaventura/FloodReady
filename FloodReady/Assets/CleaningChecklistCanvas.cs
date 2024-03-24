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
    public GameObject OverallTasks;
    // Start is called before the first frame update
    void Start()
    {
        LivingRoom.SetActive(false);
        Bathroom.SetActive(false);
        Kitchen.SetActive(false);
        Bedroom.SetActive(false);
        Hallway.SetActive(false);
        OverallTasks.SetActive(false);
        clothes.SetActive(false);
    }

    public void ShowOverall()
    {
        LivingRoom.SetActive(false);
        Bathroom.SetActive(false);
        Kitchen.SetActive(false);
        Bedroom.SetActive(false);
        Hallway.SetActive(false);
        OverallTasks.SetActive(true);
        clothes.SetActive(false);
    }

    public void ShowLivingRoomCanvas()
    {
        LivingRoom.SetActive(true);
        Bathroom.SetActive(false);
        Kitchen.SetActive(false);
        Bedroom.SetActive(false);
        Hallway.SetActive(false);
        OverallTasks.SetActive(false);
        clothes.SetActive(false);
    }


    public void ShowKitchenCanvas()
    {
        LivingRoom.SetActive(false);
        Bathroom.SetActive(false);
        Kitchen.SetActive(true);
        Bedroom.SetActive(false);
        Hallway.SetActive(false);
        OverallTasks.SetActive(false);
        clothes.SetActive(false);
    }

    

    public void ShowHallwayCanvas()
    {
        LivingRoom.SetActive(false);
        Bathroom.SetActive(false);
        Kitchen.SetActive(false);
        Bedroom.SetActive(false);
        Hallway.SetActive(true);
        OverallTasks.SetActive(false);
        clothes.SetActive(false);
    }

    public void ShowBedRoomCanvas()
    {
        LivingRoom.SetActive(false);
        Bathroom.SetActive(false);
        Kitchen.SetActive(false);
        Bedroom.SetActive(true);
        Hallway.SetActive(false);
        OverallTasks.SetActive(false);
        clothes.SetActive(false);
    }


    public void ShowBathRoomCanvas()
    {
        LivingRoom.SetActive(false);
        Bathroom.SetActive(true);
        Kitchen.SetActive(false);
        Bedroom.SetActive(false);
        Hallway.SetActive(false);
        OverallTasks.SetActive(false);
        clothes.SetActive(false);
    }

    public void ShowGatherClothesCanvas()
    {
        LivingRoom.SetActive(false);
        Bathroom.SetActive(false);
        Kitchen.SetActive(false);
        Bedroom.SetActive(false);
        Hallway.SetActive(false);
        clothes.SetActive(true);
        OverallTasks.SetActive(false);
    }

    public void deactivate()
    {
        LivingRoom.SetActive(false);
        Bathroom.SetActive(false);
        Kitchen.SetActive(false);
        Bedroom.SetActive(false);
        Hallway.SetActive(false);
        clothes.SetActive(false);
        OverallTasks.SetActive(false);

        //Destroy(ChecklistCanvas);
        Destroy(WaterNozzle);
    }
}
