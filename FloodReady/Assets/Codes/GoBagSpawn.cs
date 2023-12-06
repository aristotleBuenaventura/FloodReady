using UnityEngine;

public class GoBagSpawn : MonoBehaviour
{
    public GameObject bagPrefab;  // Drag your bag asset prefab into this field in the Inspector
    public EscapeCanvasController dial161Canvas;

    private bool hasInteracted = false;

    void Start()
    {
        bagPrefab.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the trigger collider is with an object tagged as "Player" and the interaction hasn't occurred yet
        if (!hasInteracted && other.CompareTag("Player"))
        {
            bagPrefab.SetActive(true);
            dial161Canvas.ShowSearchGoBagCanvas(true);

            // Set the flag to true to indicate that the interaction has occurred
            hasInteracted = true;
            
            // Optionally, disable the collider to prevent repeated triggers
            // GetComponent<Collider>().enabled = false;
        }
    }
}
