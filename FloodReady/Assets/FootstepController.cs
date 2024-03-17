using UnityEngine;

public class FootstepController : MonoBehaviour
{
    public AudioSource footstepSound; 

    private OVRPlayerController playerController;
    private bool isWalking = false;
    private bool isRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<OVRPlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player is walking or running based on VR joystick input
        isWalking = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).magnitude > 0.1f && OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).magnitude < 0.9f;
        isRunning = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).magnitude >= 0.9f;

        if (isWalking || isRunning)
        {
            footsteps();
        }
        else
        {
            StopFootsteps();
        }
    }

    void footsteps()
    {
        // Play footstep sound
        if (!footstepSound.isPlaying)
        {
            footstepSound.Play();
        }

        //Pitch-based Running
        if (isRunning)
        {
            footstepSound.pitch = 2f; 
        }
        else
        {
            footstepSound.pitch = 1f; 
        }
    }

    void StopFootsteps()
    {
        // Stop footstep sound
        footstepSound.Stop();
    }
}
