using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintTurnoffS2 : MonoBehaviour
{
    public GameObject TurnoffBreaker;


    void Start()
    {
        TurnoffBreaker.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
