using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkoutSide : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerTag;
    public GameObject objectsToDisable;
    public RecoveryCanvasController ShowgcheckoutsidehouseCanvasCanvas; // Reference to the canvas controller


    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerTag)
        {
            ShowgcheckoutsidehouseCanvasCanvas.ShowgcheckoutsidehouseCanvasCanvas();
            objectsToDisable.SetActive(false);
        }
    }
}
