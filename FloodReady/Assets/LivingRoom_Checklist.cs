using UnityEngine;

public class LivingRoom_Checklist : MonoBehaviour
{
    public bool[] checklist = { false, false, false, false, false, false, false, false, false };
    public LivingRoom_Clean task;
    public CleaningChecklistCanvas cleaningCanvas;
    public RecoveryCanvasController mainCanvas;
    public CleaningCollider wall;

    void Update()
    {
        // Check if all elements in the checklist are true
        bool allTrue = true;
        for (int i = 0; i < checklist.Length; i++)
        {
            if (!checklist[i])
            {
                allTrue = false;
                break;
            }
        }

        // If all elements are true, display debug.log("Finish")
        if (allTrue)
        {
            task.SetCheckIconVisible(true);
            task.SetUncheckIconVisible(false);
            cleaningCanvas.ShowKitchenCanvas();
            mainCanvas.ShowcleankitchenCanvas();
            wall.KitchenColliders();
        }
    }
}
