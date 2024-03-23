using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallway101112131415 : MonoBehaviour
{
    private double wall10amount;
    private double wall11amount;
    private double wall12amount;
    private double wall13amount;
    private double wall14amount;
    private double wall15amount;
    public IconforHW6 check;
    private bool isSet = false;
    public Hallway_Checklist checklist;
    public AudioSource Wall6_Audio;
    private bool isPlay = false;
    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public GameObject Wall4;
    public GameObject Wall5;
    public GameObject Wall6;
    public Material _material;

    public void wall10(double cleanAmount)
    {
        wall10amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall11(double cleanAmount)
    {
        wall11amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall12(double cleanAmount)
    {
        wall12amount = cleanAmount;
        CalculateTotalCleanAmount();
    }


    public void wall13(double cleanAmount)
    {
        wall13amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall14(double cleanAmount)
    {
        wall14amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall15(double cleanAmount)
    {
        wall15amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall10amount + wall11amount + wall12amount + wall13amount + wall14amount + wall15amount;
        clean_as_a_whole(totalAmount);
    }

    public void clean_as_a_whole(double totalAmount)
    {
        int totalAmountInt = (int)totalAmount;

        if (totalAmountInt >= 10)
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
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            checklist.checklist[5] = true;
            if (Wall6_Audio != null && !isPlay)
            {
                // Play the flush sound
                Wall6_Audio.Play();

                isPlay = true;
            }
            isSet = true;
        }
    }
}
