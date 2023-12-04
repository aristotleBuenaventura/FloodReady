using UnityEngine;

public class prybarShow : MonoBehaviour
{
    public EscapeCanvasController escapeCanvasController;

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
            escapeCanvasController.ShowGoRoofTop(true);

            // Optionally, disable the collider to prevent repeated triggers
            // GetComponent<Collider>().enabled = false;
        }
    }
}
