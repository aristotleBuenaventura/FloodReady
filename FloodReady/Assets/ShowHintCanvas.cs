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


    // main checklist

    public GameObject TVHint;
    public GameObject RetrieveHint;
    public GameObject UnplugHint;
    public GameObject MainBreakerHint;


    void Start()
    {     //
     
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

        // Additional hints
        if (TVHint.activeSelf)
            TVHint.SetActive(false);

        if (RetrieveHint.activeSelf)
            RetrieveHint.SetActive(false);

        if (UnplugHint.activeSelf)
            UnplugHint.SetActive(false);

        if (MainBreakerHint.activeSelf)
            MainBreakerHint.SetActive(false);
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
        TVHint.SetActive(false);
        RetrieveHint.SetActive(false);
        UnplugHint.SetActive(false);
        MainBreakerHint.SetActive(false);


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
        TVHint.SetActive(false);
        RetrieveHint.SetActive(false);
        UnplugHint.SetActive(false);
        MainBreakerHint.SetActive(false);
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
        TVHint.SetActive(false);
        RetrieveHint.SetActive(false);
        UnplugHint.SetActive(false);
        MainBreakerHint.SetActive(false);
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
        TVHint.SetActive(false);
        RetrieveHint.SetActive(false);
        UnplugHint.SetActive(false);
        MainBreakerHint.SetActive(false);
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
        TVHint.SetActive(false);
        RetrieveHint.SetActive(false);
        UnplugHint.SetActive(false);
        MainBreakerHint.SetActive(false);
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
        TVHint.SetActive(false);
        RetrieveHint.SetActive(false);
        UnplugHint.SetActive(false);
        MainBreakerHint.SetActive(false);
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
        TVHint.SetActive(false);
        RetrieveHint.SetActive(false);
        UnplugHint.SetActive(false);
        MainBreakerHint.SetActive(false);
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
        TVHint.SetActive(false);
        RetrieveHint.SetActive(false);
        UnplugHint.SetActive(false);
        MainBreakerHint.SetActive(false);
    }


    public void ShowTVCanvas()
    {
        cannedgoodHint.SetActive(false);
        energybarHint.SetActive(false);
        waterHint.SetActive(false);
        moneyHint.SetActive(false);
        clothesHints.SetActive(false);
        firstaidHint.SetActive(false);
        flashlightHint.SetActive(false);
        phoneHint.SetActive(false);
        TVHint.SetActive(true);
        RetrieveHint.SetActive(false);
        UnplugHint.SetActive(false);
        MainBreakerHint.SetActive(false);

    }


    public void ShowRetrieveCanvas()
    {
        cannedgoodHint.SetActive(false);
        energybarHint.SetActive(false);
        waterHint.SetActive(false);
        moneyHint.SetActive(false);
        clothesHints.SetActive(false);
        firstaidHint.SetActive(false);
        flashlightHint.SetActive(false);
        phoneHint.SetActive(false);
        TVHint.SetActive(false);
        RetrieveHint.SetActive(true);
        UnplugHint.SetActive(false);
        MainBreakerHint.SetActive(false);
    }

    public void ShowUnplugCanvas()
    {
        cannedgoodHint.SetActive(false);
        energybarHint.SetActive(false);
        waterHint.SetActive(false);
        moneyHint.SetActive(false);
        clothesHints.SetActive(false);
        firstaidHint.SetActive(false);
        flashlightHint.SetActive(false);
        phoneHint.SetActive(false);
        TVHint.SetActive(false);
        RetrieveHint.SetActive(false);
        UnplugHint.SetActive(true);
        MainBreakerHint.SetActive(false);
    }

    public void ShowMainBreakerCanvas()
    {
        cannedgoodHint.SetActive(false);
        energybarHint.SetActive(false);
        waterHint.SetActive(false);
        moneyHint.SetActive(false);
        clothesHints.SetActive(false);
        firstaidHint.SetActive(false);
        flashlightHint.SetActive(false);
        phoneHint.SetActive(false);
        TVHint.SetActive(false);
        RetrieveHint.SetActive(false);
        UnplugHint.SetActive(false);
        MainBreakerHint.SetActive(true);
    }
}
