using UnityEngine;

public class Flush : MonoBehaviour
{
    public MoveScaleAndDestroy moveScaleAndDestroy; // Reference to MoveScaleAndDestroy script
    public MoveAndScaleUpwardAfterDelay cleanWater;
    public AudioSource flushSound; // Reference to the AudioSource component
    public plungethetoiletIcon check;
    public TaskPercentage task;

    private bool hasExecuted = false; // Track if the code has already been executed

    private void OnTriggerEnter(Collider other)
    {
        // Check if the trigger involves an object with the "Plunge" tag and if the code has not been executed yet
        if (other.CompareTag("Plunge") && !hasExecuted)
        {
            Debug.Log("Trigger with Plunge object!");

            // Set goSignal to true for both MoveScaleAndDestroy and MoveAndScaleUpwardAfterDelay scripts
            moveScaleAndDestroy.goSignal = true;
            cleanWater.goSignal = true;
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            task.IncrementTaskPercentage(10);
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

            // Set the flag to true to indicate that the code has been executed
            hasExecuted = true;
        }
    }
}
