using UnityEngine;
using UnityEngine.UI;

public class NumberButtonController : MonoBehaviour
{
    public string number; // Set this in the Inspector for each button
    public NumberArrayManager arrayManager;

    private void Start()
    {
        // Find the NumberArrayManager script in the scene
        arrayManager = FindObjectOfType<NumberArrayManager>();
    }

    // Called when the collider enters the trigger zone
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered has the tag "TurnOnButton"
        if (other.CompareTag("TurnOnButton"))
        {
            // Call the OnButtonPress function
            OnButtonPress();
        }
    }

    // Called when the button is pressed
    public void OnButtonPress()
    {
        // Call the AddNumber function in NumberArrayManager
        Debug.Log("NAVAL");
        arrayManager.AddNumber(number);
        
    }
}
