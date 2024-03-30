using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEngine.EventSystems.EventTrigger;

public class HealthBar : MonoBehaviour
{

    public float maxLife = 10f;  // Maximum life value
    public float lifeDecreaseRate = 1f;  // Rate at which life decreases per second
    public float lifeIncreaseRate = 1f;  // Rate at which life increases per second
    public float currentLife;  // Current life value
    private Image healthbar;  // Reference to the health bar image component

    public GameObject healthBarObject;  // Assign the health bar GameObject in the Unity Editor
    public GameObject healthBarParent;  // Assign the health bar parent GameObject in the Unity Editor
    public GameObject cubeTeleport;
    public EscapeCanvasController DeathCanvas;
    public TextMeshProUGUI welldonetext;
    //public Timer_welldone timesupElapsetime;
 

    private UnderWaterEffects underwaterEffects;
    public NumberOfAttemptsScene2 retry;
    public attemptsLeftScene2 finalAttempts;

    // Start is called before the first frame update
    void Start()
    {
        cubeTeleport.SetActive(false);
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

        // Find and assign UnderWaterEffects script in the scene
        underwaterEffects = FindObjectOfType<UnderWaterEffects>();
    }

    // Update is called once per frame
    void Update()
    {
        if (underwaterEffects != null)
        {
            // Check if the camera is underwater
            if (underwaterEffects.isUnderwater)
            {
                // Decrease life
                Debug.Log("Life decreases");
                currentLife -= lifeDecreaseRate * Time.deltaTime;
            }
            else
            {
                // Increase life
                Debug.Log("Life increases");
                currentLife += lifeIncreaseRate * Time.deltaTime;
            }
        }
        else
        {
            Debug.LogWarning("UnderWaterEffects script not found!");
        }

        // Clamp life to ensure it doesn't go below 0 or above maxLife
        currentLife = Mathf.Clamp(currentLife, 0f, maxLife);

        // Update the health bar visual representation (fill amount)
        UpdateHealthBarUI();

        if (currentLife <= 0)
        {
            cubeTeleport.SetActive(true);
            //timesupElapsetime.StopTime();
           
            if (welldonetext != null)
            {
                welldonetext.text = "YOU'RE DEAD!";
            }
            retry.SetNumberOfAttempts();
            finalAttempts.updateAttempts();
            DeathCanvas.deathCanvas();
            HandlePlayerDeath();


        }
    }


    public void UpdateHealthBarUI()
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

    void HandlePlayerDeath()
    {
        /* Reset player position to the respawn point
          if (player != null && respawnPoint != null)
          {
              player.transform.position = respawnPoint.transform.position;
          }
          */

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

    public void UpdateLife(float newLife)
    {
        currentLife = newLife;
        UpdateHealthBarUI();
    }
}
