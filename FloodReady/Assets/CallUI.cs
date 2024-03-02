using UnityEngine;

public class CallUI : MonoBehaviour
{
    public GameObject HomePage;
    public GameObject CallUIs;

    void Start()
    {
        CallUIs.SetActive(false);
    }

    // Called when the collider enters another collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has the tag "TurnOnButton"
        if (other.CompareTag("TurnOnButton"))
        {
            // Disable the homepage GameObject
            HomePage.SetActive(false);
            CallUIs.SetActive(true);
        }
    }
}
