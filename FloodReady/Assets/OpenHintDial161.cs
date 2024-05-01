using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintDial161 : MonoBehaviour
{
    public GameObject Dial161;
    public ShowHintCanvasScene3 hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;

    void Start()
    {
        Dial161.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {

            hintCanvas.ShowDial161Canvas();
            if (!canDeduct)
            {
                points.DecrementPoints(2);
                canDeduct = true;
            }

        }
    }

}
