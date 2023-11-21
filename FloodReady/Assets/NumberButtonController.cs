using UnityEngine;
using UnityEngine.UI;

public class NumberButtonController : MonoBehaviour
{
    public string number; // Set this in the Inspector for each button
    public NumberArrayManager arrayManager;

    private bool canPress = true; // Flag to track if the button can be pressed
    public float cooldownTime = 1f; // Cooldown period in seconds

    private void Start()
    {
        // Find the NumberArrayManager script in the scene
        arrayManager = FindObjectOfType<NumberArrayManager>();
    }

    // Called when the collider enters the trigger zone
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered has the tag "TurnOnButton"
        if (other.CompareTag("TurnOnButton") && canPress)
        {
            // Call the OnButtonPress function
            OnButtonPress();

            // Start the cooldown
            StartCoroutine(Cooldown());
        }
    }

    // Called when the button is pressed
    public void OnButtonPress()
    {
        // Call the AddNumber function in NumberArrayManager
        Debug.Log("NAVAL");
        arrayManager.AddNumber(number);
    }

    // Coroutine for cooldown
    private System.Collections.IEnumerator Cooldown()
    {
        canPress = false;
        yield return new WaitForSeconds(cooldownTime);
        canPress = true;
    }
}
