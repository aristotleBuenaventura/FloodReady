using UnityEngine;

public class HealthBarHide : MonoBehaviour
{
    public GameObject healthBarObject;
    public GameObject player;
    public GameObject waterLevelObject;

    private bool wasBelowWater = false;

    void Start()
    {
        // Check if any necessary objects are not assigned
        if (healthBarObject == null || player == null || waterLevelObject == null)
        {
            Debug.LogError("Please assign healthBarObject, player, and waterLevelObject in the Unity Editor!");
        }
    }

    void Update()
    {
        // Check if all necessary objects are not null
        if (healthBarObject != null && player != null && waterLevelObject != null)
        {
            // Check the player's Y position
            float playerY = player.transform.position.y;
            float waterLevelY = waterLevelObject.transform.position.y;

            // Debug logs to check values
            Debug.Log("Player Y: " + playerY);
            Debug.Log("Water Level: " + waterLevelY);

            // Check if the player is below the water
            bool isBelowWater = playerY < waterLevelY;

            // Show or hide the health bar based on the player's position relative to the water level
            if (isBelowWater)
            {
                healthBarObject.SetActive(true);
                Debug.Log("Show Health Bar");
            }
            else
            {
                healthBarObject.SetActive(false);
                Debug.Log("Hide Health Bar");
            }

            // Update the state for the next frame
            wasBelowWater = isBelowWater;
        }
        else
        {
            Debug.LogError("One or more necessary objects are not assigned!");
        }
    }
}
