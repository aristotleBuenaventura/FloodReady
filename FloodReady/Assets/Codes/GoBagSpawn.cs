using UnityEngine;

public class GoBagSpawn : MonoBehaviour
{
    public GameObject bagPrefab;  // Drag your bag asset prefab into this field in the Inspector
    public EscapeCanvasController dial161Canvas;
    public iconforlocate iconMobilePhone;
    private bool hasInteracted = false;
    public LocateTheEmergencyDeviceScene2Icon task;
    public TaskPercentage locateCPincrement;

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
            iconMobilePhone.SetCheckIconVisible(true);
            iconMobilePhone.SetUncheckIconVisible(false);
            task.SetCheckIconVisible(true);
            task.SetUncheckIconVisible(false);
            locateCPincrement.IncrementTaskPercentage(10);
            // Set the flag to true to indicate that the interaction has occurred
            hasInteracted = true;

            // Optionally, disable the collider to prevent repeated triggers
            // GetComponent<Collider>().enabled = false;
        }
    }

}
