using UnityEngine;

public class UnderWaterEffects : MonoBehaviour
{
    [SerializeField] GameObject water;
    [SerializeField] GameObject cameraRig; // Reference to the camera rig
    private bool isFogActive = false;
    public bool isUnderwater { get; private set; }
    public GameObject paglubog;
    public GameObject nakalubog;

    void Update()
    {
        if (water != null && cameraRig != null) // Check if both objects are assigned
        {
            float waterHeight = water.transform.position.y;
            float cameraHeight = cameraRig.transform.position.y; // Get camera rig's height

            if (cameraHeight < waterHeight) // Activate fog if camera height is below water height
            {
                isFogActive = true;
                RenderSettings.fog = isFogActive;
                nakalubog.SetActive(true);
                paglubog.SetActive(true);
                isUnderwater = true;
            }
            else
            {
                isFogActive = false;
                RenderSettings.fog = isFogActive;
                nakalubog.SetActive(false);
                paglubog.SetActive(false);
                isUnderwater = false;
            }
        }
        else
        {
            Debug.LogWarning("Water or camera rig is not assigned!");
        }


    }
}
