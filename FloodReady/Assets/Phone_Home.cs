using UnityEngine;

public class Phone_Home : MonoBehaviour
{
    public GameObject WallPaper;
    public GameObject HomePage;
    public GameObject CallUI;
    public AudioSource unlock;

    void Start()
    {
        WallPaper.SetActive(true);
        HomePage.SetActive(false);
        CallUI.SetActive(false);
    }

    // Called when the collider enters another collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has the tag "TurnOnButton"
        if (other.CompareTag("TurnOnButton"))
        {
            // Disable the homepage GameObject
            WallPaper.SetActive(false);
            HomePage.SetActive(true);
            CallUI.SetActive(false);
            unlock.Play();
        }
    }
}
