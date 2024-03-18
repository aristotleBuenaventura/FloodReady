using UnityEngine;
using UnityEngine.UI;

public class HealthBarOverlay : MonoBehaviour
{
    public HealthBar healthBar; // Reference to the HealthBar script

    public Image healthImage1; // Reference to the first UI Image element
    public Image healthImage2; // Reference to the second UI Image element

    void Update()
    {
        // Check if the healthBar reference is set
        if (healthBar != null)
        {
            // Update the UI images based on the health bar's current life
            UpdateUIImages(healthBar.currentLife);
            Debug.Log("NOT UPDATING");
        }
        else
        {
            Debug.LogError("HealthBar reference not set in HealthBarOverlay script!");
        }
    }

    void UpdateUIImages(float currentLife)
    {
        // Enable/disable UI images based on current life
        if (healthImage1 != null && healthImage2 != null)
        {
            // Calculate fill amount based on current life and maximum life
            float fillAmount = currentLife / healthBar.maxLife;

            // Set the fill amount of the health bar images
            healthImage1.fillAmount = fillAmount;
            healthImage2.fillAmount = fillAmount;
        }
        else
        {
            Debug.LogError("One or both of the UI Image references are not set in HealthBarOverlay script!");
        }
    }
}
