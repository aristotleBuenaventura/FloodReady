using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2Task : MonoBehaviour
{
    public GameObject RetrieveGoBagCanvas;
    public GameObject TurnOffMainBreakerCanvas;
    public GameObject LocateTheSurvivalToolCanvas;
    public GameObject BreakAWindowCanvas;
    public GameObject LocateTheEmergencyDeviceCanvas;
    public GameObject Dial161Canvas;

    void Start()
    {
        RetrieveGoBagCanvas.SetActive(false);
        TurnOffMainBreakerCanvas.SetActive(false);
        LocateTheSurvivalToolCanvas.SetActive(false);
        BreakAWindowCanvas.SetActive(false);
        LocateTheEmergencyDeviceCanvas.SetActive(false);
        Dial161Canvas.SetActive(false);
    }

    public void RetrieveGobag()
    {
        RetrieveGoBagCanvas.SetActive(true);
        TurnOffMainBreakerCanvas.SetActive(false);
        LocateTheSurvivalToolCanvas.SetActive(false);
        BreakAWindowCanvas.SetActive(false);
        LocateTheEmergencyDeviceCanvas.SetActive(false);
        Dial161Canvas.SetActive(false);
    }

    public void TurnOffMainBreaker()
    {
        RetrieveGoBagCanvas.SetActive(false);
        TurnOffMainBreakerCanvas.SetActive(true);
        LocateTheSurvivalToolCanvas.SetActive(false);
        BreakAWindowCanvas.SetActive(false);
        LocateTheEmergencyDeviceCanvas.SetActive(false);
        Dial161Canvas.SetActive(false);
    }

    public void LocateTheSurvivalTool()
    {
        RetrieveGoBagCanvas.SetActive(false);
        TurnOffMainBreakerCanvas.SetActive(false);
        LocateTheSurvivalToolCanvas.SetActive(true);
        BreakAWindowCanvas.SetActive(false);
        LocateTheEmergencyDeviceCanvas.SetActive(false);
        Dial161Canvas.SetActive(false);
    }

    public void BreakAWindow()
    {
        RetrieveGoBagCanvas.SetActive(false);
        TurnOffMainBreakerCanvas.SetActive(false);
        LocateTheSurvivalToolCanvas.SetActive(false);
        BreakAWindowCanvas.SetActive(true);
        LocateTheEmergencyDeviceCanvas.SetActive(false);
        Dial161Canvas.SetActive(false);
    }

    public void LocateTheEmergencyDevice()
    {
        RetrieveGoBagCanvas.SetActive(false);
        TurnOffMainBreakerCanvas.SetActive(false);
        LocateTheSurvivalToolCanvas.SetActive(false);
        BreakAWindowCanvas.SetActive(false);
        LocateTheEmergencyDeviceCanvas.SetActive(true);
        Dial161Canvas.SetActive(false);
    }

    public void Dial161()
    {
        RetrieveGoBagCanvas.SetActive(false);
        TurnOffMainBreakerCanvas.SetActive(false);
        LocateTheSurvivalToolCanvas.SetActive(false);
        BreakAWindowCanvas.SetActive(false);
        LocateTheEmergencyDeviceCanvas.SetActive(false);
        Dial161Canvas.SetActive(true);
    }


}
