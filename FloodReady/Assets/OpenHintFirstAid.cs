using System.Collections;
using UnityEngine;

public class OpenHintFirstAid : MonoBehaviour
{
    public GameObject FirstAid;
    public ShowHintCanvas hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;


    // Start is called before the first frame update
    void Start()
    {
        FirstAid.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {


            hintCanvas.ShowFirstAidCanvas();
           
            if (!canDeduct)
            {
                points.DecrementPoints(1);
                canDeduct = true;
            }

   
            
         
        }
    }

}
