using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallway_18_MiniGame : MonoBehaviour
{
    private double wall18amount;
    public IconforHW8 check;
    private bool isSet = false;
    public Hallway_Checklist_MiniGame checklist;
    public AudioSource Wall8_Audio;
    private bool isPlay = false;
    public GameObject Wall1;
    public Material _material;

    public void wall18(double cleanAmount)
    {
        wall18amount = cleanAmount;
        CalculateTotalCleanAmount();
    }


    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall18amount;
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
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            checklist.checklist[7] = true;
            if (Wall8_Audio != null && !isPlay)
            {
                // Play the flush sound
                Wall8_Audio.Play();

                isPlay = true;
            }
            isSet = true;
        }
    }
}
