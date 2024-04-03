using UnityEngine;

public class ShowDoorJam : MonoBehaviour
{
    public EscapeCanvasController escapeCanvasController;
    public TaskPercentage leavethehouse;
    public TotalPoints points;
    public TryToLeaveTheHouseChecklist check;
    public TryToLeaveTheHouseIcon task;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // You can add any specific conditions to trigger the canvas in the Update method if needed
    }

    private void OnTriggerEnter(Collider other)
    {
        // Assuming the collider is set to "isTrigger"
        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER WALKS");

            // Call the ShowDoorJamCanvas method in EscapeCanvasController with the parameter true
            escapeCanvasController.ShowDoorJamCanvas(true);
            leavethehouse.IncrementTaskPercentage(10);
            points.IncrementPoints(1000);
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            task.SetCheckIconVisible(true);
            task.SetUncheckIconVisible(false);
            // Optionally, disable the collider to prevent repeated triggers
            // GetComponent<Collider>().enabled = false;
        }
    }
}
