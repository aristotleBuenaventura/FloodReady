using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintTryleaveHouseS2 : MonoBehaviour
{
    public GameObject TryleaveHouseS2;
    public ShowHintCanvasScene2 hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;


    void Start()
    {
        TryleaveHouseS2.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {



            hintCanvas.LeaveHouseCanvas();
            if (!canDeduct)
            {
                points.DecrementPoints(50);
                canDeduct = true;
            }


        }
    }
}
