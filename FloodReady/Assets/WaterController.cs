using UnityEngine;

public class WaterController : MonoBehaviour
{
    public ParticleSystem waterParticles;
    private bool isButtonPressed = false;
    private bool isHandColliding = false;

    void Start()
    {
        // Ensure the water particle system starts off
        if (waterParticles != null)
        {
            // Option 1: Disable emission (if using the Shuriken Particle System)
            var emissionModule = waterParticles.emission;
            emissionModule.enabled = false;

            // Option 2: Stop the entire particle system
            // waterParticles.Stop();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has the "Hand" tag
        if (other.CompareTag("Hand"))
        {
            isHandColliding = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the previously collided object has the "Hand" tag
        if (other.CompareTag("Hand"))
        {
            isHandColliding = false;

            // Turn off the water particle system when the hand exits
            if (waterParticles != null)
            {
                var emissionModule = waterParticles.emission;
                emissionModule.enabled = false;
            }
        }
    }

    void Update()
    {
        // Check for Oculus Touch controller trigger press to turn on (adjust as needed)
        if (isHandColliding && OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            isButtonPressed = true;

            // Turn on the water particle system when the hand is colliding and the trigger is pressed
            if (waterParticles != null)
            {
                var emissionModule = waterParticles.emission;
                emissionModule.enabled = true;
            }
        }

        // Check for Oculus Touch controller trigger release to turn off (adjust as needed)
        if (OVRInput.GetUp(OVRInput.Button.SecondaryIndexTrigger))
        {
            isButtonPressed = false;

            // Turn off the water particle system when the trigger is released
            if (waterParticles != null)
            {
                var emissionModule = waterParticles.emission;
                emissionModule.enabled = false;
            }
        }
    }
}
