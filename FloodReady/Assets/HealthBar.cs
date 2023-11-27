using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float maxLife = 10f;  // Maximum life value
    public float lifeDecreaseRate = 1f;  // Rate at which life decreases per second
    public float lifeIncreaseRate = 1f;  // Rate at which life increases per second
    private float currentLife;  // Current life value
    private Image healthbar;  // Reference to the health bar image component

    public GameObject healthBarObject;  // Assign the health bar GameObject in the Unity Editor
    public GameObject healthBarParent;  // Assign the health bar parent GameObject in the Unity Editor
    public GameObject player; // Assign the player GameObject (OVRPlayerController) in the Unity Editor
    public GameObject water; // Assign the water GameObject in the Unity Editor
    public GameObject respawnPoint;  // Assign the respawn point GameObject in the Unity Editor

    // Start is called before the first frame update
    void Start()
    {
        currentLife = maxLife;  // Initialize current life to maxLife

        if (healthBarObject != null)
        {
            healthbar = healthBarObject.GetComponent<Image>();  // Get the Image component from the assigned healthBarObject
        }
        else
        {
            Debug.LogError("Health bar GameObject not assigned!");
        }

        if (healthBarParent == null)
        {
            Debug.LogError("Health bar parent GameObject not assigned!");
        }

        if (respawnPoint == null)
        {
            Debug.LogError("Respawn point GameObject not assigned!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player is higher than the water
        if (water != null && player != null && player.transform.position.y > water.transform.position.y)
        {
            // Increase life over time
            Debug.Log("Life increases");
            currentLife += lifeIncreaseRate * Time.deltaTime;
        }
        else
        {
            // Decrease life over time
            Debug.Log("Life decreases");
            currentLife -= lifeDecreaseRate * Time.deltaTime;
        }

        // Clamp life to ensure it doesn't go below 0 or above maxLife
        currentLife = Mathf.Clamp(currentLife, 0f, maxLife);

        // Update the health bar visual representation (fill amount)
        UpdateHealthBarUI();

        // Check if life is zero and trigger player death
        if (currentLife <= 0)
        {
            PlayerDied();
        }
    }

    void UpdateHealthBarUI()
    {
        // Calculate fill amount based on current life and maximum life
        float fillAmount = currentLife / maxLife;

        // Set the fill amount of the health bar image
        if (healthbar != null)
        {
            healthbar.fillAmount = fillAmount;

            // Check if life is full and disable the entire healthBarParent
            if (currentLife >= maxLife)
            {
                DisableHealthBarParent();
            }
            else
            {
                EnableHealthBarParent();
            }
        }
        else
        {
            Debug.LogError("Health bar Image component not found!");
        }
    }

    void PlayerDied()
    {
        // Reset player position to the respawn point
        if (player != null && respawnPoint != null)
        {
            player.transform.position = respawnPoint.transform.position;
        }

        // Reset currentLife to maxLife
        currentLife = maxLife;

        // Disable the health bar parent when the player dies
        DisableHealthBarParent();
    }

    void DisableHealthBarParent()
    {
        if (healthBarParent != null)
        {
            healthBarParent.SetActive(false);
        }
    }

    void EnableHealthBarParent()
    {
        if (healthBarParent != null)
        {
            healthBarParent.SetActive(true);
        }
    }
}
