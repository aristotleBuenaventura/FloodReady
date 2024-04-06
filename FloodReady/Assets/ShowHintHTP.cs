using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHintHTP : MonoBehaviour
{
    public GameObject PlayGrabHint;
    public GameObject PlayWaterNozzleHint;
    public GameObject PlayCellphoneHint;
    public GameObject HintCellphoneHint;
    public GameObject HintGrabFlashlight;
    public GameObject HintGrabFirstAid;
    public GameObject HintGrabCannedGood;
    public GameObject HintWaterNozzle;
    public GameObject PlayTutorialHint;

    void Start()
    {

    }
    public void HideAllCanvas()
    {
        if (PlayGrabHint.activeSelf)
            PlayGrabHint.SetActive(false);

        if (PlayWaterNozzleHint.activeSelf)
            PlayWaterNozzleHint.SetActive(false);

        if (PlayCellphoneHint.activeSelf)
            PlayCellphoneHint.SetActive(false);

        if (HintCellphoneHint.activeSelf)
            HintCellphoneHint.SetActive(false);

        if (HintGrabFlashlight.activeSelf)
            HintGrabFlashlight.SetActive(false);

        if (HintGrabFirstAid.activeSelf)
            HintGrabFirstAid.SetActive(false);

        if (HintGrabCannedGood.activeSelf)
            HintGrabCannedGood.SetActive(false);

        if (HintWaterNozzle.activeSelf)
            HintWaterNozzle.SetActive(false);


        if (PlayTutorialHint.activeSelf)
            PlayTutorialHint.SetActive(false);
    }


    public void ShowPlayGrabHint()
    {
        PlayGrabHint.SetActive(true);
        PlayWaterNozzleHint.SetActive(false);
        PlayCellphoneHint.SetActive(false);
        HintCellphoneHint.SetActive(false);
        HintGrabFlashlight.SetActive(false);
        HintGrabFirstAid.SetActive(false);
        HintGrabCannedGood.SetActive(false);
        HintWaterNozzle.SetActive(false);
        PlayTutorialHint.SetActive(false);
    }

    public void ShowPlayWaterNozzleHint()
    {
        PlayGrabHint.SetActive(false);
        PlayWaterNozzleHint.SetActive(true);
        PlayCellphoneHint.SetActive(false);
        HintCellphoneHint.SetActive(false);
        HintGrabFlashlight.SetActive(false);
        HintGrabFirstAid.SetActive(false);
        HintGrabCannedGood.SetActive(false);
        HintWaterNozzle.SetActive(false);
        PlayTutorialHint.SetActive(false);
    }

    public void ShowPlayCellphoneHint()
    {
        PlayGrabHint.SetActive(false);
        PlayWaterNozzleHint.SetActive(false);
        PlayCellphoneHint.SetActive(true);
        HintCellphoneHint.SetActive(false);
        HintGrabFlashlight.SetActive(false);
        HintGrabFirstAid.SetActive(false);
        HintGrabCannedGood.SetActive(false);
        HintWaterNozzle.SetActive(false);
        PlayTutorialHint.SetActive(false);
    }

    public void ShowHintCellphoneHint()
    {
        PlayGrabHint.SetActive(false);
        PlayWaterNozzleHint.SetActive(false);
        PlayCellphoneHint.SetActive(false);
        HintCellphoneHint.SetActive(true);
        HintGrabFlashlight.SetActive(false);
        HintGrabFirstAid.SetActive(false);
        HintGrabCannedGood.SetActive(false);
        HintWaterNozzle.SetActive(false);
        PlayTutorialHint.SetActive(false);
    }

    public void ShowHintGrabFlashlight()
    {
        PlayGrabHint.SetActive(false);
        PlayWaterNozzleHint.SetActive(false);
        PlayCellphoneHint.SetActive(false);
        HintCellphoneHint.SetActive(false);
        HintGrabFlashlight.SetActive(true);
        HintGrabFirstAid.SetActive(false);
        HintGrabCannedGood.SetActive(false);
        HintWaterNozzle.SetActive(false);
        PlayTutorialHint.SetActive(false);
    }

    public void ShowHintGrabFirstAid()
    {
        PlayGrabHint.SetActive(false);
        PlayWaterNozzleHint.SetActive(false);
        PlayCellphoneHint.SetActive(false);
        HintCellphoneHint.SetActive(false);
        HintGrabFlashlight.SetActive(false);
        HintGrabFirstAid.SetActive(true);
        HintGrabCannedGood.SetActive(false);
        HintWaterNozzle.SetActive(false);
        PlayTutorialHint.SetActive(false);
    }

    public void ShowHintGrabCannedGood()
    {
        PlayGrabHint.SetActive(false);
        PlayWaterNozzleHint.SetActive(false);
        PlayCellphoneHint.SetActive(false);
        HintCellphoneHint.SetActive(false);
        HintGrabFlashlight.SetActive(false);
        HintGrabFirstAid.SetActive(false);
        HintGrabCannedGood.SetActive(true);
        HintWaterNozzle.SetActive(false);
        PlayTutorialHint.SetActive(false);
    }

    public void ShowHintWaterNozzle()
    {
        PlayGrabHint.SetActive(false);
        PlayWaterNozzleHint.SetActive(false);
        PlayCellphoneHint.SetActive(false);
        HintCellphoneHint.SetActive(false);
        HintGrabFlashlight.SetActive(false);
        HintGrabFirstAid.SetActive(false);
        HintGrabCannedGood.SetActive(false);
        HintWaterNozzle.SetActive(true);
        PlayTutorialHint.SetActive(false);
    }

    public void ShowPlayTutorialHint()
    {
        PlayGrabHint.SetActive(false);
        PlayWaterNozzleHint.SetActive(false);
        PlayCellphoneHint.SetActive(false);
        HintCellphoneHint.SetActive(false);
        HintGrabFlashlight.SetActive(false);
        HintGrabFirstAid.SetActive(false);
        HintGrabCannedGood.SetActive(false);
        HintWaterNozzle.SetActive(false);
        PlayTutorialHint.SetActive(true);
    }
}
