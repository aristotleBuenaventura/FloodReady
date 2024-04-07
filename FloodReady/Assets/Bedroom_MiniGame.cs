using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bedroom_MiniGame : MonoBehaviour
{
    public bool[] checklist = { false, false, false, false, false};
    public CanvasMiniGame MainCanvas;
    public GameObject Cleaned;
    public GameObject Dirty;

    void Start()
    {
        Dirty.SetActive(true);
        Cleaned.SetActive(false);
    }
    // Start is called before the first frame update
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
            Dirty.SetActive(false);
            Cleaned.SetActive(true);
            MainCanvas.showCleaningDone();
            enabled = false;
        }


    }
}
