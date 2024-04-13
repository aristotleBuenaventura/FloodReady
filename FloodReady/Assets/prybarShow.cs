using UnityEngine;

public class PrybarShow : MonoBehaviour
{
    public EscapeCanvasController escapeCanvasController;
    private bool hasInteracted = false;   
    void Start()
    {
    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!hasInteracted && other.CompareTag("Player"))
        {
            Debug.Log("PLAYER WALKS");

            // Call the ShowGoRoofTop method in EscapeCanvasController with the parameter true
            escapeCanvasController.ShowGoRoofTop(true);

            // Set the flag to true to indicate that the interaction has occurred
            hasInteracted = true;

        }
    }
}
