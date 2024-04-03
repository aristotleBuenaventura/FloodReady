using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchMobilePhone : MonoBehaviour
{
    private bool checklistShown = false;
    public GameObject canvas;
    public CanvasToggle toggle;
    public GameObject prybarOnHand;
    public GameObject flashlightOnHand;

    void Start()
    {
        if (!checklistShown)
        {
            prybarOnHand.SetActive(false);
            flashlightOnHand.SetActive(false);
            toggle.showChecklist();
            canvas.SetActive(true);
            checklistShown = true;
        }
    }
}
