using UnityEngine;

public class checkoutSide : MonoBehaviour
{
    // Reference to the GameObject to monitor
    public GameObject monitorObject;
    // GameObject to be turned on when the monitorObject is enabled
    public GameObject turnOnObject;
    public RecoveryCanvasController UsePhoneCanvas; // Reference to the canvas controller
    public GameObject objectsToDisable;
    public GameObject playerTag;

    void Start()
    {
        // Check if the monitorObject is enabled initially
        if (monitorObject.activeSelf)

        {
            if (turnOnObject != null)
                turnOnObject.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerTag)
        {
            UsePhoneCanvas.UsePhoneCanvas();
            objectsToDisable.SetActive(false);
        }
    }
}
