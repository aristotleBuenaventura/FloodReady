using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHintCanvasScene2 : MonoBehaviour
{
    public GameObject GoBag;
    public GameObject MainBreaker;
    public GameObject PryBar;
    public GameObject BreakWindow;
    public GameObject LocateEmergencyDevice;
    public GameObject Dial161;
    public GameObject TurnOnFL;

    public GameObject LeaveHouse;

    public GameObject Escape2ndFloor;
    void Start()
    {

    }

    public void HideAllCanvas()
    {
        if (GoBag.activeSelf)
            GoBag.SetActive(false);

        if (MainBreaker.activeSelf)
            MainBreaker.SetActive(false);

        if (PryBar.activeSelf)
            PryBar.SetActive(false);

        if (BreakWindow.activeSelf)
            BreakWindow.SetActive(false);

        if (LocateEmergencyDevice.activeSelf)
            LocateEmergencyDevice.SetActive(false);

        if (Dial161.activeSelf)
            Dial161.SetActive(false);


        if (TurnOnFL.activeSelf)
            TurnOnFL.SetActive(false);

        if (LeaveHouse.activeSelf)
            LeaveHouse.SetActive(false);

        if (Escape2ndFloor.activeSelf)
            Escape2ndFloor.SetActive(false);
    }

    public void ShowGoBagCanvas()
    {
        GoBag.SetActive(true);
        MainBreaker.SetActive(false);
        PryBar.SetActive(false);
        BreakWindow.SetActive(false);
        LocateEmergencyDevice.SetActive(false);
        Dial161.SetActive(false);
        TurnOnFL.SetActive(false);
        LeaveHouse.SetActive(false);
        Escape2ndFloor.SetActive(false);
    }

    public void ShowMainBreakerCanvas()
    {
        GoBag.SetActive(false);
        MainBreaker.SetActive(true);
        PryBar.SetActive(false);
        BreakWindow.SetActive(false);
        LocateEmergencyDevice.SetActive(false);
        Dial161.SetActive(false);
        TurnOnFL.SetActive(false);
        LeaveHouse.SetActive(false);
        Escape2ndFloor.SetActive(false);
    }

    public void ShowPryBarCanvas()
    {
        GoBag.SetActive(false);
        MainBreaker.SetActive(false);
        PryBar.SetActive(true);
        BreakWindow.SetActive(false);
        LocateEmergencyDevice.SetActive(false);
        Dial161.SetActive(false);
        TurnOnFL.SetActive(false);
        LeaveHouse.SetActive(false);
        Escape2ndFloor.SetActive(false);
    }

    public void ShowBreakWindowCanvas()
    {
        GoBag.SetActive(false);
        MainBreaker.SetActive(false);
        PryBar.SetActive(false);
        BreakWindow.SetActive(true);
        LocateEmergencyDevice.SetActive(false);
        Dial161.SetActive(false);
        TurnOnFL.SetActive(false);
        LeaveHouse.SetActive(false);
        Escape2ndFloor.SetActive(false);
    }

    public void ShowLocateEmergencyDeviceCanvas()
    {
        GoBag.SetActive(false);
        MainBreaker.SetActive(false);
        PryBar.SetActive(false);
        BreakWindow.SetActive(false);
        LocateEmergencyDevice.SetActive(true);
        Dial161.SetActive(false);
        TurnOnFL.SetActive(false);
        LeaveHouse.SetActive(false);
        Escape2ndFloor.SetActive(false);
    }

    public void ShowDial161Canvas()
    {
        GoBag.SetActive(false);
        MainBreaker.SetActive(false);
        PryBar.SetActive(false);
        BreakWindow.SetActive(false);
        LocateEmergencyDevice.SetActive(false);
        Dial161.SetActive(true);
        TurnOnFL.SetActive(false);
        LeaveHouse.SetActive(false);
        Escape2ndFloor.SetActive(false);
    }


    public void TurnOnFLCanvas()
    {
        GoBag.SetActive(false);
        MainBreaker.SetActive(false);
        PryBar.SetActive(false);
        BreakWindow.SetActive(false);
        LocateEmergencyDevice.SetActive(false);
        Dial161.SetActive(false);
        TurnOnFL.SetActive(true);
        LeaveHouse.SetActive(false);
        Escape2ndFloor.SetActive(false);
    }

    public void LeaveHouseCanvas()
    {
        GoBag.SetActive(false);
        MainBreaker.SetActive(false);
        PryBar.SetActive(false);
        BreakWindow.SetActive(false);
        LocateEmergencyDevice.SetActive(false);
        Dial161.SetActive(false);
        TurnOnFL.SetActive(false);
        LeaveHouse.SetActive(true);
        Escape2ndFloor.SetActive(false);
    }

    public void Escape2ndFloorCanvas()
    {
        GoBag.SetActive(false);
        MainBreaker.SetActive(false);
        PryBar.SetActive(false);
        BreakWindow.SetActive(false);
        LocateEmergencyDevice.SetActive(false);
        Dial161.SetActive(false);
        TurnOnFL.SetActive(false);
        LeaveHouse.SetActive(false);
        Escape2ndFloor.SetActive(true);
    }
}
