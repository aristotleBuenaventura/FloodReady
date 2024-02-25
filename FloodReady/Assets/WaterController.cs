using UnityEngine;

public class WaterController : MonoBehaviour
{
    public ParticleSystem waterParticles;
    public AudioSource waterSound;
    public bool isButtonPressed = false;
    private bool isHandColliding = false;

    public bool IsButtonPressed // Add a public property to access isButtonPressed
    {
        get { return isButtonPressed; }
    }

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
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            isHandColliding = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the previously collided object has the "Hand" tag
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
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

            // Update isButtonPressed when hand exits
            isButtonPressed = false;
        }
    }

    void Update()
    {
        // Check for Oculus Touch controller trigger press to turn on (adjust as needed)
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
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
