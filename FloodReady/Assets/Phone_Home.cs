using UnityEngine;

public class Phone_Home : MonoBehaviour
{
    public GameObject WallPaper;
    public GameObject HomePage;
    public GameObject Contact;
    public GameObject Dial;
    public GameObject Calling;
    public AudioSource unlock;

    void Start()
    {
        WallPaper.SetActive(true);
        HomePage.SetActive(false);
        Contact.SetActive(false);
        Dial.SetActive(false);
        Calling.SetActive(false);
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
            Contact.SetActive(false);
            Calling.SetActive(false);
            Dial.SetActive(false);
            unlock.Play();
        }
    }
}
