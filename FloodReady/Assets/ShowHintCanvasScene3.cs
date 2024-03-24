using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHintCanvasScene3 : MonoBehaviour
{
    public GameObject GasHint;
    public GameObject GasValve;
    public GameObject AssessHouse;
    public GameObject FindWaterNozzle;
    public GameObject FindPlunger;
    public GameObject Cloth1;
    public GameObject Cloth2;
    public GameObject Cloth3;
    public GameObject Cloth4;
    public GameObject Cloth5;
    public GameObject PlungerToilet;
    public GameObject CheckNeighborhood;
    public GameObject Dial161;

    void Start()
    {

    }

    public void HideAllCanvas()
    {
        if (GasHint.activeSelf)
            GasHint.SetActive(false);

        if (GasValve.activeSelf)
            GasValve.SetActive(false);  

        if (AssessHouse.activeSelf)
            AssessHouse.SetActive(false);

        if (FindWaterNozzle.activeSelf)
            FindWaterNozzle.SetActive(false);

        if (FindPlunger.activeSelf)
            FindPlunger.SetActive(false);

        if (Cloth1.activeSelf)
            Cloth1.SetActive(false);

        if (Cloth2.activeSelf)
            Cloth2.SetActive(false);

        if (Cloth3.activeSelf)
            Cloth3.SetActive(false);

        if (Cloth4.activeSelf)
            Cloth4.SetActive(false);

        if (Cloth5.activeSelf)
            Cloth5.SetActive(false);

        if (PlungerToilet.activeSelf)
            PlungerToilet.SetActive(false);

        if (CheckNeighborhood.activeSelf)
            CheckNeighborhood.SetActive(false);

        if (Dial161.activeSelf)
            Dial161.SetActive(false);
    }

    public void ShowGasHintCanvas()
    {
        GasHint.SetActive(true);
        GasValve.SetActive(false);
        AssessHouse.SetActive(false);
        FindWaterNozzle.SetActive(false);
        FindPlunger.SetActive(false);
        Cloth1.SetActive(false);
        Cloth2.SetActive(false);
        Cloth3.SetActive(false);
        Cloth4.SetActive(false);
        Cloth5.SetActive(false);
        PlungerToilet.SetActive(false);
        CheckNeighborhood.SetActive(false);
        Dial161.SetActive(false);
    }

    public void ShowGasValveCanvas()
    {
        GasHint.SetActive(false);
        GasValve.SetActive(true);
        AssessHouse.SetActive(false);
        FindWaterNozzle.SetActive(false);
        FindPlunger.SetActive(false);
        Cloth1.SetActive(false);
        Cloth2.SetActive(false);
        Cloth3.SetActive(false);
        Cloth4.SetActive(false);
        Cloth5.SetActive(false);
        PlungerToilet.SetActive(false);
        CheckNeighborhood.SetActive(false);
        Dial161.SetActive(false);
    }

    public void ShowAssessHouseCanvas()
    {
        GasHint.SetActive(false);
        GasValve.SetActive(false);
        AssessHouse.SetActive(true);
        FindWaterNozzle.SetActive(false);
        FindPlunger.SetActive(false);
        Cloth1.SetActive(false);
        Cloth2.SetActive(false);
        Cloth3.SetActive(false);
        Cloth4.SetActive(false);
        Cloth5.SetActive(false);
        PlungerToilet.SetActive(false);
        CheckNeighborhood.SetActive(false);
        Dial161.SetActive(false);
    }

    public void ShowFindWaterNozzleCanvas()
    {
        GasHint.SetActive(false);
        GasValve.SetActive(false);
        AssessHouse.SetActive(false);
        FindWaterNozzle.SetActive(true);
        FindPlunger.SetActive(false);
        Cloth1.SetActive(false);
        Cloth2.SetActive(false);
        Cloth3.SetActive(false);
        Cloth4.SetActive(false);
        Cloth5.SetActive(false);
        PlungerToilet.SetActive(false);
        CheckNeighborhood.SetActive(false);
        Dial161.SetActive(false);
    }

    public void ShowFindPlungerCanvas()
    {
        GasHint.SetActive(false);
        GasValve.SetActive(false);
        AssessHouse.SetActive(false);
        FindWaterNozzle.SetActive(false);
        FindPlunger.SetActive(true);
        Cloth1.SetActive(false);
        Cloth2.SetActive(false);
        Cloth3.SetActive(false);
        Cloth4.SetActive(false);
        Cloth5.SetActive(false);
        PlungerToilet.SetActive(false);
        CheckNeighborhood.SetActive(false);
        Dial161.SetActive(false);
    }

    public void ShowCloth1Canvas()
    {
        GasHint.SetActive(false);
        GasValve.SetActive(false);
        AssessHouse.SetActive(false);
        FindWaterNozzle.SetActive(false);
        FindPlunger.SetActive(false);
        Cloth1.SetActive(true);
        Cloth2.SetActive(false);
        Cloth3.SetActive(false);
        Cloth4.SetActive(false);
        Cloth5.SetActive(false);
        PlungerToilet.SetActive(false);
        CheckNeighborhood.SetActive(false);
        Dial161.SetActive(false);
    }

    public void ShowCloth2Canvas()
    {
        GasHint.SetActive(false);
        GasValve.SetActive(false);
        AssessHouse.SetActive(false);
        FindWaterNozzle.SetActive(false);
        FindPlunger.SetActive(false);
        Cloth1.SetActive(false);
        Cloth2.SetActive(true);
        Cloth3.SetActive(false);
        Cloth4.SetActive(false);
        Cloth5.SetActive(false);
        PlungerToilet.SetActive(false);
        CheckNeighborhood.SetActive(false);
        Dial161.SetActive(false);
    }

    public void ShowCloth3Canvas()
    {
        GasHint.SetActive(false);
        GasValve.SetActive(false);
        AssessHouse.SetActive(false);
        FindWaterNozzle.SetActive(false);
        FindPlunger.SetActive(false);
        Cloth1.SetActive(false);
        Cloth2.SetActive(false);
        Cloth3.SetActive(true);
        Cloth4.SetActive(false);
        Cloth5.SetActive(false);
        PlungerToilet.SetActive(false);
        CheckNeighborhood.SetActive(false);
        Dial161.SetActive(false);
    }

    public void ShowCloth4Canvas()
    {
        GasHint.SetActive(false);
        GasValve.SetActive(false);
        AssessHouse.SetActive(false);
        FindWaterNozzle.SetActive(false);
        FindPlunger.SetActive(false);
        Cloth1.SetActive(false);
        Cloth2.SetActive(false);
        Cloth3.SetActive(false);
        Cloth4.SetActive(true);
        Cloth5.SetActive(false);
        PlungerToilet.SetActive(false);
        CheckNeighborhood.SetActive(false);
        Dial161.SetActive(false);
    }

    public void ShowCloth5Canvas()
    {
        GasHint.SetActive(false);
        GasValve.SetActive(false);
        AssessHouse.SetActive(false);
        FindWaterNozzle.SetActive(false);
        FindPlunger.SetActive(false);
        Cloth1.SetActive(false);
        Cloth2.SetActive(false);
        Cloth3.SetActive(false);
        Cloth4.SetActive(false);
        Cloth5.SetActive(true);
        PlungerToilet.SetActive(false);
        CheckNeighborhood.SetActive(false);
        Dial161.SetActive(false);
    }

    public void ShowPlungerToiletCanvas()
    {
        GasHint.SetActive(false);
        GasValve.SetActive(false);
        AssessHouse.SetActive(false);
        FindWaterNozzle.SetActive(false);
        FindPlunger.SetActive(false);
        Cloth1.SetActive(false);
        Cloth2.SetActive(false);
        Cloth3.SetActive(false);
        Cloth4.SetActive(false);
        Cloth5.SetActive(false);
        PlungerToilet.SetActive(true);
        CheckNeighborhood.SetActive(false);
        Dial161.SetActive(false);
    }

    public void ShowCheckNeighborhoodCanvas()
    {
        GasHint.SetActive(false);
        GasValve.SetActive(false);
        AssessHouse.SetActive(false);
        FindWaterNozzle.SetActive(false);
        FindPlunger.SetActive(false);
        Cloth1.SetActive(false);
        Cloth2.SetActive(false);
        Cloth3.SetActive(false);
        Cloth4.SetActive(false);
        Cloth5.SetActive(false);
        PlungerToilet.SetActive(false);
        CheckNeighborhood.SetActive(true);
        Dial161.SetActive(false);
    }

    public void ShowDial161Canvas()
    {
        GasHint.SetActive(false);
        GasValve.SetActive(false);
        AssessHouse.SetActive(false);
        FindWaterNozzle.SetActive(false);
        FindPlunger.SetActive(false);
        Cloth1.SetActive(false);
        Cloth2.SetActive(false);
        Cloth3.SetActive(false);
        Cloth4.SetActive(false);
        Cloth5.SetActive(false);
        PlungerToilet.SetActive(false);
        CheckNeighborhood.SetActive(false);
        Dial161.SetActive(true);
    }
}

