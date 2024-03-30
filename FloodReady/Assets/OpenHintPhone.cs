using System.Collections;
using UnityEngine;

public class OpenHintPhone : MonoBehaviour
{
    public GameObject Phone;
    public ShowHintCanvas hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;
 

    // Start is called before the first frame update
    void Start()
    {
        Phone.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {
  

            hintCanvas.ShowPhoneCanvas();
         
            if (!canDeduct)
            {
                points.DecrementPoints(100);
                canDeduct = true;
            }

  

        }
    }


}
