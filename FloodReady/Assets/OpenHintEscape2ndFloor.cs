using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintEscape2ndFloor : MonoBehaviour
{
    public GameObject Escape2ndFloor;
    public ShowHintCanvasScene2 hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;



    void Start()
    {
        Escape2ndFloor.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {



            hintCanvas.Escape2ndFloorCanvas();
            if (!canDeduct)
            {
                points.DecrementPoints(2);

                canDeduct = true;
            }


        }
    }
}
