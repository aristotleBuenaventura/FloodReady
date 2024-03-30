using UnityEngine;

public class FootstepControllerS2 : MonoBehaviour
{
    public AudioSource footstepSoundLand;
    public AudioSource footstepSoundWater;
    private OVRPlayerController playerController;
    private bool isWalking = false;
    private bool isRunning = false;
    private bool isInWater = false;
    public GameObject DisableLandFootStep;


    private bool playerDetected = false;
    private WaterLevelController waterLevelController;


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
            if (isInWater)
            {
                footstepsWater();
            }
            else
            {
                footstepsLand();
            }
        }
        else
        {
            StopFootsteps();
        }
    }

    void footstepsLand()
    {
        // Play footstep sound for land
        if (!footstepSoundLand.isPlaying)
        {
            footstepSoundLand.Play();
        }

        // Pitch adjustment based on running
        if (isRunning)
        {
            footstepSoundLand.pitch = 2f;
        }
        else
        {
            footstepSoundLand.pitch = 1f;
        }
    }

    void footstepsWater()
    {
        // Play footstep sound for water
        if (!footstepSoundWater.isPlaying)
        {
            footstepSoundWater.Play();
        }

        // Pitch adjustment based on running
        if (isRunning)
        {
            footstepSoundWater.pitch = 2f;
        }
        else
        {
            footstepSoundWater.pitch = 1f;
        }
    }

    void StopFootsteps()
    {
        // Stop footstep sounds
        footstepSoundLand.Stop();
        footstepSoundWater.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("water walk");
            isInWater = true;
            playerDetected = true;
            DisableLandFootStep.SetActive(false);
        }

   
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInWater = false;
            playerDetected = false;
            DisableLandFootStep.SetActive(true);
        }
    }



}
