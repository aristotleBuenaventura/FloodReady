using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlepoint : MonoBehaviour
{
    private bool checklistShown = false;
    public GameObject canvas;
    public CanvasToggle toggle;
    public GameObject Bag;
    public GameObject MobilePhoneOnHand;

    void Start()
    {
        if (!checklistShown)
        {
            MobilePhoneOnHand.SetActive(false);
            Bag.SetActive(false);
            toggle.showChecklist();
            canvas.SetActive(true);
            checklistShown = true;
        }
    }
}
