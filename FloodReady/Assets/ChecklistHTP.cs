using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecklistHTP : MonoBehaviour
{
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
}
