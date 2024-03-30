using UnityEngine;

public class CheckPlayer : MonoBehaviour
{
    public GameObject playerTag;
    public GameObject objectsToDisable;
    public CheckNeighborhoodIcon checklist;
    public RecoveryCanvasController UsePhoneCanvas;
    public GameObject goBag;
    public GameObject DestroyHint;




    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerTag)
        {
            // Check if the object to disable is active before disabling it
            if (objectsToDisable.activeSelf)
            {
                // Disable the object

                Destroy(DestroyHint);
                objectsToDisable.SetActive(false);
                checklist.SetCheckIconVisible(true);
                checklist.SetUncheckIconVisible(false);
                UsePhoneCanvas.UsePhoneCanvas();
                goBag.SetActive(true);

            }
        }
    }
}
