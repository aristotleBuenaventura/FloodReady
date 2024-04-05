using UnityEngine;

public class WaterControllerHTP : MonoBehaviour
{
    public ParticleSystem waterParticles;
    public AudioSource waterSound;
    public bool isButtonPressed = false;
    public bool isHandColliding = false;
    public WaterNozzleIcon nozzle;

    void Start()
    {
        // Ensure the water particle system starts off
        if (waterParticles != null)
        {
            var emissionModule = waterParticles.emission;
            emissionModule.enabled = false;
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

            // Turn off the water particle system and sound when the hand exits
            if (waterParticles != null)
            {
                var emissionModule = waterParticles.emission;
                emissionModule.enabled = false;
            }
            if (waterSound != null)
            {
                waterSound.Stop();
            }
        }
    }

    void Update()
    {
        // Check for Oculus Touch controller trigger press to turn on (adjust as needed)
        if (isHandColliding && OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            isButtonPressed = true;

            // Turn on the water particle system and play the water sound when the hand is colliding and the trigger is pressed
            if (waterParticles != null)
            {
                var emissionModule = waterParticles.emission;
                emissionModule.enabled = true;
            }
            if (waterSound != null)
            {
                waterSound.Play();
                nozzle.SetUncheckIconVisible(false);
                nozzle.SetCheckIconVisible(true);
            }
        }

        // Check for Oculus Touch controller trigger release to turn off (adjust as needed)
        if (OVRInput.GetUp(OVRInput.Button.SecondaryIndexTrigger))
        {
            isButtonPressed = false;

            // Turn off the water particle system and stop the water sound when the trigger is released
            if (waterParticles != null)
            {
                var emissionModule = waterParticles.emission;
                emissionModule.enabled = false;
            }
            if (waterSound != null)
            {
                waterSound.Stop();
            }
        }
    }
}
