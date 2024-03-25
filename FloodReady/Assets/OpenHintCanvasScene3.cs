using UnityEngine;

public class OpenHintCanvasScene3 : MonoBehaviour
{
    public ShowHintCanvasScene3 showHintCanvas;
    private bool canTrigger = true; // Flag to control trigger activation

    public GameObject objectToMonitor1;
    public GameObject objectToMonitor2;
    public GameObject objectToMonitor3;
    public GameObject objectToMonitor4;
    public GameObject objectToMonitor5;
    public GameObject objectToMonitor6;
    public GameObject objectToMonitor7;
    public GameObject objectToMonitor8;
    public GameObject objectToMonitor9;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered the trigger is the player or controller 
        if (other.CompareTag("Hand") && canTrigger)
        {

            SetObjectActive(objectToMonitor1, true); // sinu-sure lang na i true lahat ng icons 
            SetObjectActive(objectToMonitor2, true);
            SetObjectActive(objectToMonitor3, true);
            SetObjectActive(objectToMonitor4, true);
            SetObjectActive(objectToMonitor5, true);
            SetObjectActive(objectToMonitor6, true);
            SetObjectActive(objectToMonitor7, true);
            SetObjectActive(objectToMonitor8, true);
            SetObjectActive(objectToMonitor9, true);


        }
    }

    private void SetObjectActive(GameObject obj, bool active)
    {
        // Check if the object reference is not null // mahalaga tong setobjective kasi chinecheck if not null para maiwasan ang error pag na destory na ang icon // lagi dapat may null para maiwasan ang error sa destory ginawa ko to sa prepare go bag check mo yung
        // inventory manager switch case 
        if (obj != null)
        {
            obj.SetActive(active);
        }
    }
}
