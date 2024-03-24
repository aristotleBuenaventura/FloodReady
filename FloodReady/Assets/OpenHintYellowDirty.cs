using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintYellowDirty : MonoBehaviour
{
    public GameObject YellowDirty;
    public ShowHintCanvasScene3 hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;
    public RecoveryCanvasController RecoveryCanvasController;

    void Start()
    {
        YellowDirty.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {

            hintCanvas.ShowCloth3Canvas();
            RecoveryCanvasController.HideAllCanvas();
            if (!canDeduct)
            {
                points.DecrementPoints(200);
                canDeduct = true;
            }

        }
    }
}
