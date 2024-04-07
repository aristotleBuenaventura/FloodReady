using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeMiniGame : MonoBehaviour
{
    public CanvasToggle nozzle;
    public GameObject WaterNozzle;
    // Start is called before the first frame update
    void Start()
    {
        nozzle.showChecklist();
        WaterNozzle.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
