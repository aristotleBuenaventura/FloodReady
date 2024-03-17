using UnityEngine;

public class PlayerDisableCollide : MonoBehaviour
{
    public GameObject playerTag;
    public GameObject objectsToDisable;
  
    public AudioClip disableSound; // Sound to play when object is disabled




    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerTag)
        {
            // Check if the object to disable is active before disabling it
            if (objectsToDisable.activeSelf)
            {
                // Disable the object
                objectsToDisable.SetActive(false);
             

                // Play the disable sound
                if (disableSound != null)
                {
                    AudioSource.PlayClipAtPoint(disableSound, objectsToDisable.transform.position);
                }
            }
        }
    }
}
