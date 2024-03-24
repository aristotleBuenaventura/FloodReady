using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bathroom_Wall456 : MonoBehaviour
{
    private double wall4amount;
    private double wall5amount;
    private double wall6amount;
    public IconforBRW4 check;
    private bool isSet = false;
    public Bathroom_Checklist checklist;
    public AudioSource Wall4_Audio;
    private bool isPlay = false;
    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public Material _material;

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
        wall6amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall4amount + wall5amount + wall6amount;
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
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            checklist.checklist[0] = true;
            if (Wall4_Audio != null && !isPlay)
            {
                // Play the flush sound
                Wall4_Audio.Play();

                isPlay = true;
            }
            isSet = true;
        }
    }

}
