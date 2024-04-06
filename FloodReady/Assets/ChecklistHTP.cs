using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecklistHTP : MonoBehaviour
{
    public bool[] checklist = { false, false, false, false, false, false, false, false, false };
    public GameObject Portal;
    public GameObject PortalBarricade;
    public GameObject TrainingRoomChecklist;
    public GameObject HouseFamiliarizationChecklist;

    // Start is called before the first frame update
    void Start()
    {
        Portal.SetActive(false);
        PortalBarricade.SetActive(true);
        TrainingRoomChecklist.SetActive(true);
        HouseFamiliarizationChecklist.SetActive(false);
    }

    public void ShowPortal()
    {
        Portal.SetActive(true);
        PortalBarricade.SetActive(false);
        TrainingRoomChecklist.SetActive(false);
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

            ShowPortal();
            enabled = false;
        }

        
    }
}
