using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OpenHintGasLeak : MonoBehaviour
{
    public GameObject gasHint; // to set disable the hint icon at start
    public ShowHintCanvasScene3 hintCanvas; // calling the hint canvas
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;

    void Start()
    {
        gasHint.SetActive(false); // to set disable the hint icon at start of the game
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {

            hintCanvas.ShowGasHintCanvas(); // calling the hint canvas to show the hint 
            if (!canDeduct)
            {
                points.DecrementPoints(1);
                canDeduct = true;
            }

        }
    }

}
