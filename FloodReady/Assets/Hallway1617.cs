using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallway1617 : MonoBehaviour
{
    private double wall16amount;
    private double wall17amount;
    public IconforHW7 check;
    private bool isSet = false;
    public Hallway_Checklist checklist;
    public AudioSource Wall7_Audio;
    private bool isPlay = false;
    public GameObject Wall1;
    public GameObject Wall2;
    public Material _material;

    public void wall16(double cleanAmount)
    {
        wall16amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall17(double cleanAmount)
    {
        wall17amount = cleanAmount;
        CalculateTotalCleanAmount();
    }


    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall16amount + wall17amount;
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
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            checklist.checklist[6] = true;
            if (Wall7_Audio != null && !isPlay)
            {
                // Play the flush sound
                Wall7_Audio.Play();

                isPlay = true;
            }
            isSet = true;
        }
    }
}
