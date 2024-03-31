using UnityEngine;
using System.Collections;

public class LivingRoom_Checklist_Minigame : MonoBehaviour
{
    public bool[] checklist = { false, false, false, false, false, false, false, false, false };


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

            StartCoroutine(ShowKitchenCanvasAfterDelay(2f));

            enabled = false; // Disable the script

        }
    }

    IEnumerator ShowKitchenCanvasAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

    }
}
