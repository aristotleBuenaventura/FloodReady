using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTimeDrown : MonoBehaviour
{
    public TimerScene2 stop;
    // Start is called before the first frame update
    void Start()
    {
        stop.StopTimer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
