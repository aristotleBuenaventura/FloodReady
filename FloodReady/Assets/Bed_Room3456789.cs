using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed_Room3456789 : MonoBehaviour
{
    private double wall3amount;
    private double wall4amount;
    private double wall5amount;
    private double wall6amount;
    private double wall7amount;
    private double wall8amount;
    private double wall9amount;
    public iconforBDW3 check;
    private bool isSet = false;
    public Bedroom_Checklist checklist;
    public AudioSource Wall3_Audio;
    private bool isPlay = false;
    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public GameObject Wall4;
    public GameObject Wall5;
    public GameObject Wall6;
    public GameObject Wall7;
    public Material _material;

    public void wall3(double cleanAmount)
    {
        wall3amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall4(double cleanAmount)
    {
        wall4amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall5(double cleanAmount)
    {
        wall5amount = cleanAmount;
        CalculateTotalCleanAmount();
    }


    public void wall6(double cleanAmount)
    {
        wall5amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall7(double cleanAmount)
    {
        wall7amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall8(double cleanAmount)
    {
        wall8amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall9(double cleanAmount)
    {
        wall9amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall3amount + wall4amount + wall5amount + wall5amount + wall7amount + wall8amount + wall9amount;
        clean_as_a_whole(totalAmount);
    }

    public void clean_as_a_whole(double totalAmount)
    {
        int totalAmountInt = (int)totalAmount;

        if (totalAmountInt >= 80)
        {
            totalAmountInt = 100; // Update totalAmountInt directly to 100
        }

        CleanAmountManager.UpdateCleanAmount(totalAmountInt); // Update CleanAmountManager after modifying totalAmountInt

        if (totalAmountInt == 100 && !isSet)
        {
            Wall1.GetComponent<Renderer>().material = _material;
            Wall2.GetComponent<Renderer>().material = _material;
            Wall3.GetComponent<Renderer>().material = _material;
            Wall4.GetComponent<Renderer>().material = _material;
            Wall5.GetComponent<Renderer>().material = _material;
            Wall6.GetComponent<Renderer>().material = _material;
            Wall7.GetComponent<Renderer>().material = _material;
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            checklist.checklist[2] = true;
            if (Wall3_Audio != null && !isPlay)
            {
                // Play the flush sound
                Wall3_Audio.Play();

                isPlay = true;
            }
            isSet = true;
        }
    }
}
