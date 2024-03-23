using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintBreakS2 : MonoBehaviour
{
    public GameObject BreakWindow;
    public ShowHintCanvasScene2 hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;

    void Start()
    {
        BreakWindow.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {

     

            hintCanvas.ShowBreakWindowCanvas();
            if (!canDeduct)
            {
                points.DecrementPoints(200);
                canDeduct = true;
            }



        }
    }


}
