using UnityEngine;

public class LifeIncreaseManager : MonoBehaviour
{
    public GameObject player;
    public GameObject water;
    public float lifeIncreaseRate = 1f; // Rate at which life increases per second

    private HealthBar healthBar;

    void Start()
    {
        // Get reference to the HealthBar script attached to the player GameObject
        healthBar = player.GetComponent<HealthBar>();
        if (healthBar == null)
        {
            Debug.LogError("HealthBar script not found on the player GameObject!");
        }
    }

    void Update()
    {
        // Check if the player and water references are not null
        if (player != null && water != null)
        {
            // Check if the player is higher than the water
            if (player.transform.position.y > water.transform.position.y)
            {
                // Increase life over time
                healthBar.currentLife += lifeIncreaseRate * Time.deltaTime;

                // Clamp life to ensure it doesn't exceed maxLife
                healthBar.currentLife = Mathf.Clamp(healthBar.currentLife, 0f, healthBar.maxLife);

                // Update the health bar UI
                healthBar.UpdateHealthBarUI();

                Debug.Log("Life increased: " + healthBar.currentLife);
            }
            else
            {
                Debug.Log("Player is not above water.");
            }
        }
        else
        {
            Debug.LogError("Player or water GameObject reference is null!");
        }
    }
}
