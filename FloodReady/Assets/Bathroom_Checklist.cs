using UnityEngine;

public class Bathroom_Checklist : MonoBehaviour
{
    public bool[] checklist = { false, false, false, false, false, false };

    // Call this method to check if all checklist items are true
    public void CheckIfAllItemsDone()
    {
        bool allDone = true;
        foreach (bool item in checklist)
        {
            if (!item)
            {
                allDone = false;
                break;
            }
        }

        if (allDone)
        {
            Debug.Log("Done");
        }
        else
        {
            Debug.Log("Not all items are done yet");
        }
    }

    // Example of how to call this method
    void Start()
    {
        CheckIfAllItemsDone();
    }
}
