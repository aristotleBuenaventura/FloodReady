using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarHide : MonoBehaviour
{
    public GameObject healthBarObject;
    public GameObject player;
    public GameObject waterLevelObject;

    private bool wasBelowWater = false;

    void Start()
    {
        if (healthBarObject == null || player == null || waterLevelObject == null)
        {
            Debug.LogError("Please assign healthBarObject, player, and waterLevelObject in the Unity Editor!");
        }
    }

    void Update()
    {
        // Debug logs to check values
        Debug.Log("Player Y: " + player.transform.position.y);
        Debug.Log("Water Level: " + waterLevelObject.transform.position.y);

        // Check if the player is below the water
        bool isBelowWater = waterLevelObject != null && player != null && player.transform.position.y < waterLevelObject.transform.position.y;

        // Show the health bar if the player was not below water and is now below water
        if (wasBelowWater && isBelowWater)
        {
            healthBarObject.SetActive(true);
            Debug.Log("Show Health Bar");
        }
        // Hide the health bar if the player was below water and is not below water anymore
        else if (!wasBelowWater && !isBelowWater)
        {
            healthBarObject.SetActive(false);
            Debug.Log("Hide Health Bar");
        }

        // Update the state for the next frame
        wasBelowWater = isBelowWater;

        // Check if the water is rising
        WaterLevelController waterLevelController = waterLevelObject.GetComponent<WaterLevelController>();
        if (waterLevelController != null && waterLevelController.IsWaterRising())
        {
            Debug.Log("Water is rising!");
        }
    }
}
