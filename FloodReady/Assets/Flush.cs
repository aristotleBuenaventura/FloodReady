using UnityEngine;

public class Flush : MonoBehaviour
{
    public MoveScaleAndDestroy moveScaleAndDestroy; // Reference to MoveScaleAndDestroy script
    public MoveAndScaleUpwardAfterDelay cleanWater;
    public AudioSource flushSound; // Reference to the AudioSource component

    private void OnTriggerEnter(Collider other)
    {
        // Check if the trigger involves an object with the "Plunge" tag
        if (other.CompareTag("Plunge"))
        {
            Debug.Log("Trigger with Plunge object!");

            // Set goSignal to true for both MoveScaleAndDestroy and MoveAndScaleUpwardAfterDelay scripts
            moveScaleAndDestroy.goSignal = true;
            cleanWater.goSignal = true;

            // Check if flushSound is assigned
            if (flushSound != null)
            {
                // Play the flush sound
                flushSound.Play();
            }
            else
            {
                Debug.LogWarning("Flush sound is not assigned!");
            }
        }
    }
}
