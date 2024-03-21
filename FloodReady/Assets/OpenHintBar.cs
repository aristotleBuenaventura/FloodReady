using System.Collections;
using UnityEngine;

public class OpenHintBar : MonoBehaviour
{
    public GameObject EnergyBar;
    public ShowHintCanvas hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;

    // Start is called before the first frame update
    void Start()
    {
        EnergyBar.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {


            hintCanvas.ShowEnergyCanvas();
            if (!canDeduct)
            {
                points.DecrementPoints(100);
                canDeduct = true;
            }


           
        }
    }
}
