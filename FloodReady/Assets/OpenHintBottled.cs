using System.Collections;
using UnityEngine;

public class OpenHintBottled : MonoBehaviour
{
    public GameObject Bottled;
    public ShowHintCanvas hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;
   

    // Start is called before the first frame update
    void Start()
    {
        Bottled.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {


            hintCanvas.ShoWaterCanvas();
        
            if (!canDeduct)
            {
                points.DecrementPoints(1);
                canDeduct = true;
            }


        }
    }

}
