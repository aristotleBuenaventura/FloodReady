using UnityEngine;

public class Flush : MonoBehaviour
{
    public MoveScaleAndDestroy moveScaleAndDestroy; // Reference to MoveScaleAndDestroy script

    private void OnTriggerEnter(Collider other)
    {
        // Check if the trigger involves an object with the "Plunge" tag
        if (other.CompareTag("Plunge"))
        {
            Debug.Log("Trigger with Plunge object!");
            
            moveScaleAndDestroy.goSignal = true; // Set goSignal to true or false based on your requirement
            
        }
    }
}
