using UnityEngine;

public class CheckPlayer : MonoBehaviour
{
    public GameObject playerTag;
    public GameObject objectsToDisable;

    public RecoveryCanvasController UsePhoneCanvas;
    public GameObject goBag;



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerTag)
        {
            // Check if the object to disable is active before disabling it
            if (objectsToDisable.activeSelf)
            {
                // Disable the object
                objectsToDisable.SetActive(false);
                UsePhoneCanvas.UsePhoneCanvas();
                goBag.SetActive(true);

            }
        }
    }
}
