using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallway_Checklist_MiniGame : MonoBehaviour
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
     
            // Disable the script
            enabled = false;
        }

        IEnumerator ShowBedroomCanvasAfterDelay(float delay)
        {
            yield return new WaitForSeconds(delay);
     

        }
    }
}
