using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecklistIMU : MonoBehaviour
{
    public bool[] checklist = { false, false, false, false, false, false};
    public GameObject Portal2;
    public GameObject PortalBarricade;
    public GameObject TrainingRoomChecklist;
    public GameObject IMUChecklist;
    public GameObject HouseFamiliarizationChecklist;
    public CanvasControllerFirstCanvasHTP ShowProceedHouseCanvas;


    public void ShowPortal()
    {
        Portal2.SetActive(true);
        PortalBarricade.SetActive(false);
        TrainingRoomChecklist.SetActive(false);
        IMUChecklist.SetActive(false);
        HouseFamiliarizationChecklist.SetActive(true);
    }

    void Update()
    {
        // Check if all elements in the checklist are true
        bool allTrue = true;
        for (int i = 0; i < checklist.Length; i++)
        {
            if (!checklist[i])
            {
                allTrue = false;
                break;
            }
        }

        // If all elements are true, display debug.log("Finish")
        if (allTrue)
        {
            ShowProceedHouseCanvas.ShowProceedHouseCanvas();
            ShowPortal();
            enabled = false;
        }


    }
}
