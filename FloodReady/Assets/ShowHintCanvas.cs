using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHintCanvas : MonoBehaviour
{
    public GameObject cannedgoodHint;
    public GameObject energybarHint;
    public GameObject waterHint;
    public GameObject moneyHint;
    public GameObject clothesHints;
    public GameObject firstaidHint;
    public GameObject flashlightHint;
    public GameObject phoneHint;


    private GameObject[] canvasList; // Array to hold all canvas game objects
    private int currentCanvasIndex = 0; // Index of the currently active canvas

    void Start()
    {
        // Initialize the canvas list
        canvasList = new GameObject[] { cannedgoodHint, energybarHint, waterHint, moneyHint, clothesHints, firstaidHint, flashlightHint, phoneHint };

        // Hide all canvases except the first one
        for (int i = 1; i < canvasList.Length; i++)
        {
            canvasList[i].SetActive(false);
        }
    }


    // Method to show the next canvas
    public void ShowNextCanvas()
    {
        // Hide the current canvas
        canvasList[currentCanvasIndex].SetActive(false);

        // Move to the next canvas
        currentCanvasIndex = (currentCanvasIndex + 1) % canvasList.Length;

        // Show the next canvas
        canvasList[currentCanvasIndex].SetActive(true);
    }

    // Method to show the previous canvas
    public void ShowPreviousCanvas()
    {
        // Hide the current canvas
        canvasList[currentCanvasIndex].SetActive(false);

        // Move to the previous canvas
        currentCanvasIndex = (currentCanvasIndex - 1 + canvasList.Length) % canvasList.Length;

        // Show the previous canvas
        canvasList[currentCanvasIndex].SetActive(true);
    }

    public void HideAllCanvas()
    {
        if (cannedgoodHint.activeSelf)
            cannedgoodHint.SetActive(false);

        if (energybarHint.activeSelf)
            energybarHint.SetActive(false);

        if (waterHint.activeSelf)
            waterHint.SetActive(false);

        if (moneyHint.activeSelf)
            moneyHint.SetActive(false);

        if (clothesHints.activeSelf)
            clothesHints.SetActive(false);

        if (firstaidHint.activeSelf)
            firstaidHint.SetActive(false);

        if (flashlightHint.activeSelf)
            flashlightHint.SetActive(false);

        if (phoneHint.activeSelf)
            phoneHint.SetActive(false);
    }

    public void ShowCannedCanvas()
    {
        cannedgoodHint.SetActive(true);
        energybarHint.SetActive(false);
        waterHint.SetActive(false);
        moneyHint.SetActive(false);
        clothesHints.SetActive(false);
        firstaidHint.SetActive(false);
        flashlightHint.SetActive(false);
        phoneHint.SetActive(false);
      

    }

    public void ShowEnergyCanvas()
    {
        cannedgoodHint.SetActive(false);
        energybarHint.SetActive(true);
        waterHint.SetActive(false);
        moneyHint.SetActive(false);
        clothesHints.SetActive(false);
        firstaidHint.SetActive(false);
        flashlightHint.SetActive(false);
        phoneHint.SetActive(false);
    }

    public void ShoWaterCanvas()
    {
        cannedgoodHint.SetActive(false);
        energybarHint.SetActive(false);
        waterHint.SetActive(true);
        moneyHint.SetActive(false);
        clothesHints.SetActive(false);
        firstaidHint.SetActive(false);
        flashlightHint.SetActive(false);
        phoneHint.SetActive(false);
    }


    public void ShowMoneyCanvas()
    {
        cannedgoodHint.SetActive(false);
        energybarHint.SetActive(false);
        waterHint.SetActive(false);
        moneyHint.SetActive(true);
        clothesHints.SetActive(false);
        firstaidHint.SetActive(false);
        flashlightHint.SetActive(false);
        phoneHint.SetActive(false);
    }

    public void ShowClothesCanvas()
    {
        cannedgoodHint.SetActive(false);
        energybarHint.SetActive(false);
        waterHint.SetActive(false);
        moneyHint.SetActive(false);
        clothesHints.SetActive(true);
        firstaidHint.SetActive(false);
        flashlightHint.SetActive(false);
        phoneHint.SetActive(false);
    }

    public void ShowFirstAidCanvas()
    {
        cannedgoodHint.SetActive(false);
        energybarHint.SetActive(false);
        waterHint.SetActive(false);
        moneyHint.SetActive(false);
        clothesHints.SetActive(false);
        firstaidHint.SetActive(true);
        flashlightHint.SetActive(false);
        phoneHint.SetActive(false);
    }

    public void ShowFlashlightCanvas()
    {
        cannedgoodHint.SetActive(false);
        energybarHint.SetActive(false);
        waterHint.SetActive(false);
        moneyHint.SetActive(false);
        clothesHints.SetActive(false);
        firstaidHint.SetActive(false);
        flashlightHint.SetActive(true);
        phoneHint.SetActive(false);
    }

    public void ShowPhoneCanvas()
    {
        cannedgoodHint.SetActive(false);
        energybarHint.SetActive(false);
        waterHint.SetActive(false);
        moneyHint.SetActive(false);
        clothesHints.SetActive(false);
        firstaidHint.SetActive(false);
        flashlightHint.SetActive(false);
        phoneHint.SetActive(true);
    }



}
