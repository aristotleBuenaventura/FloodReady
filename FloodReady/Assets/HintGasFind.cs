using UnityEngine;

public class HintGasFind : MonoBehaviour
{
    public GameObject playerTag; // Assign the player GameObject to this variable in the Inspector
    public GameObject objectToDisable; // Assign the GameObject you want to disable to this variable in the Inspector
    public RecoveryCanvasController ShowclosegasleakCanvas;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerTag)
        {
            // If the gas bottle hint collides with the player, deactivate the specified GameObject
            objectToDisable.SetActive(false);
            ShowclosegasleakCanvas.ShowclosegasleakCanvas();
        }
    }
}