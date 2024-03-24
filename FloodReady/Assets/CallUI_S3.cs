using UnityEngine;

public class CallUI_S3 : MonoBehaviour
{
    public GameObject HomePage;
    public GameObject Contact;
    public GameObject Dial;
    public GameObject Calling;
    public AudioSource key;

    void Start()
    {
        HomePage.SetActive(true);
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
            key.Play();
            HomePage.SetActive(false);
            Contact.SetActive(true);
            Dial.SetActive(false);
            Calling.SetActive(false);
            // Disable the homepage GameObject
        }
    }
}
