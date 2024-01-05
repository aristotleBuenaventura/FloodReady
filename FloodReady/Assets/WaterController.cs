using UnityEngine;

public class WaterController : MonoBehaviour
{
    public ParticleSystem waterParticles;
    private bool isButtonPressed = false;

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

    void Update()
    {
        // Check for Oculus Touch controller trigger press to turn on (adjust as needed)
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            isButtonPressed = true;
        }

        // Check for Oculus Touch controller trigger release to turn off (adjust as needed)
        if (OVRInput.GetUp(OVRInput.Button.SecondaryIndexTrigger))
        {
            isButtonPressed = false;

            // Turn off the water particle system
            if (waterParticles != null)
            {
                // Option 1: Disable emission (if using the Shuriken Particle System)
                var emissionModule = waterParticles.emission;
                emissionModule.enabled = false;

                // Option 2: Stop the entire particle system
                // waterParticles.Stop();
            }
        }

        // Check if the trigger is continuously pressed
        if (isButtonPressed)
        {
            // Turn on the water particle system
            if (waterParticles != null)
            {
                // Option 1: Enable emission (if using the Shuriken Particle System)
                var emissionModule = waterParticles.emission;
                emissionModule.enabled = true;

                // Option 2: Play the entire particle system
                // waterParticles.Play();
            }
        }
    }
}
