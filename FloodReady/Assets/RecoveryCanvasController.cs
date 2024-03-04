using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RecoveryCanvasController : MonoBehaviour
{
    // Add any new canvas references here
    public GameObject welcomeCanvas;
    public GameObject gasleakCanvas;
    public GameObject closegasleakCanvas;
    public GameObject checwholehouseCanvas;
    public GameObject findnozzleCanvas;
    public GameObject cleanlivingCanvas;
    public GameObject cleankitchenCanvas;
    public GameObject cleansecondhallwayCanvas;
    public GameObject cleanBedroomwallCanvas;
    public GameObject cleanbathroomCanvas;
    public GameObject findPlungerCanvas;
    public GameObject plungedtoiletCanvas;
    public GameObject gatherDirtyclothesCanvas;
    public GameObject checkOutSideCanvas;
    public GameObject usePhoneCanvas;
    public GameObject dial1161Canvas;
    public GameObject successCanvas;
    public GameObject failedCanvas;
    public MessageCanvas messageCanvas;
    public float switchDelayWelcome = 10f;

   // collider
    public GameObject roomBarrierCollider1;
    public Collider roomBarrierCollider2;
    public BoxCollider roomBarrierCollider3;
    public BoxCollider roomBarrierCollider4;


    public CheckHouse checkHouse; // Reference to the CheckHouse script
    public GameObject waterSpray;




    private void Start()
    {
        // Ensure the welcome canvas starts in the desired state
        ShowWelcomeCanvas();
        StartCoroutine(SwitchCanvasAfterDelay());
        waterSpray.SetActive(false);

    }

    // Add any new canvas show functions here
    private void ShowWelcomeCanvas()
    {
        welcomeCanvas.SetActive(true);
        gasleakCanvas.SetActive(false);
        closegasleakCanvas.SetActive(false);
        checwholehouseCanvas.SetActive(false);
        findnozzleCanvas.SetActive(false);
        cleanlivingCanvas.SetActive(false);
        cleankitchenCanvas.SetActive(false);
        cleansecondhallwayCanvas.SetActive(false);
        cleanBedroomwallCanvas.SetActive(false);
        cleanbathroomCanvas.SetActive(false);
        findPlungerCanvas.SetActive(false);
        plungedtoiletCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(false);
        checkOutSideCanvas.SetActive(false);
        usePhoneCanvas.SetActive(false);
        dial1161Canvas.SetActive(false);
        successCanvas.SetActive(false);
        failedCanvas.SetActive(false);


    

        messageCanvas.OpenCanvasAgain();
    }

    public void ShowgasleakCanvasCanvas()
    {
        welcomeCanvas.SetActive(false);
        gasleakCanvas.SetActive(true);
        closegasleakCanvas.SetActive(false);
        checwholehouseCanvas.SetActive(false);
        findnozzleCanvas.SetActive(false);
        cleanlivingCanvas.SetActive(false);
        cleankitchenCanvas.SetActive(false);
        cleansecondhallwayCanvas.SetActive(false);
        cleanBedroomwallCanvas.SetActive(false);
        cleanbathroomCanvas.SetActive(false);
        findPlungerCanvas.SetActive(false);
        plungedtoiletCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(false);
        checkOutSideCanvas.SetActive(false);
        usePhoneCanvas.SetActive(false);
        dial1161Canvas.SetActive(false);
        successCanvas.SetActive(false);
        failedCanvas.SetActive(false);
        SetRoomBarrierColliderActive1(false);



        messageCanvas.OpenCanvasAgain();
    }

    public void ShowclosegasleakCanvas()
    {
        welcomeCanvas.SetActive(false);
        gasleakCanvas.SetActive(false);
        closegasleakCanvas.SetActive(true);
        checwholehouseCanvas.SetActive(false);
        findnozzleCanvas.SetActive(false);
        cleanlivingCanvas.SetActive(false);
        cleankitchenCanvas.SetActive(false);
        cleansecondhallwayCanvas.SetActive(false);
        cleanBedroomwallCanvas.SetActive(false);
        cleanbathroomCanvas.SetActive(false);
        findPlungerCanvas.SetActive(false);
        plungedtoiletCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(false);
        checkOutSideCanvas.SetActive(false);
        usePhoneCanvas.SetActive(false);
        dial1161Canvas.SetActive(false);
        successCanvas.SetActive(false);
        failedCanvas.SetActive(false);




        messageCanvas.OpenCanvasAgain();
        SetRoomBarrierColliderActive2(false);

    }

    public void ShowchecwholehouseCanvas()
    {
        welcomeCanvas.SetActive(false);
        gasleakCanvas.SetActive(false);
        closegasleakCanvas.SetActive(false);
        checwholehouseCanvas.SetActive(true);
        findnozzleCanvas.SetActive(false);
        cleanlivingCanvas.SetActive(false);
        cleankitchenCanvas.SetActive(false);
        cleansecondhallwayCanvas.SetActive(false);
        cleanBedroomwallCanvas.SetActive(false);
        cleanbathroomCanvas.SetActive(false);
        findPlungerCanvas.SetActive(false);
        plungedtoiletCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(false);
        checkOutSideCanvas.SetActive(false);
        usePhoneCanvas.SetActive(false);
        dial1161Canvas.SetActive(false);
        successCanvas.SetActive(false);
        failedCanvas.SetActive(false);


        if (checkHouse != null)
            checkHouse.TurnOnObjects();
        messageCanvas.OpenCanvasAgain();
        SetRoomBarrierColliderActive2(false);
       

    }

    public void ShowfindnozzleCanvas()
    {



        welcomeCanvas.SetActive(false);
        gasleakCanvas.SetActive(false);
        closegasleakCanvas.SetActive(false);
        checwholehouseCanvas.SetActive(false);
        findnozzleCanvas.SetActive(true);
        cleanlivingCanvas.SetActive(false);
        cleankitchenCanvas.SetActive(false);
        cleansecondhallwayCanvas.SetActive(false);
        cleanBedroomwallCanvas.SetActive(false);
        cleanbathroomCanvas.SetActive(false);
        findPlungerCanvas.SetActive(false);
        plungedtoiletCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(false);
        checkOutSideCanvas.SetActive(false);
        usePhoneCanvas.SetActive(false);
        dial1161Canvas.SetActive(false);
        successCanvas.SetActive(false);
        failedCanvas.SetActive(false);




        messageCanvas.OpenCanvasAgain();
        SetRoomBarrierColliderActive4(false);


       
    }


    public void ShowcleanlivingCanvas()
    {

        welcomeCanvas.SetActive(false);
        gasleakCanvas.SetActive(false);
        closegasleakCanvas.SetActive(false);
        checwholehouseCanvas.SetActive(false);
        findnozzleCanvas.SetActive(false);
        cleanlivingCanvas.SetActive(true);
        cleankitchenCanvas.SetActive(false);
        cleansecondhallwayCanvas.SetActive(false);
        cleanBedroomwallCanvas.SetActive(false);
        cleanbathroomCanvas.SetActive(false);
        findPlungerCanvas.SetActive(false);
        plungedtoiletCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(false);
        checkOutSideCanvas.SetActive(false);
        usePhoneCanvas.SetActive(false);
        dial1161Canvas.SetActive(false);
        successCanvas.SetActive(false);
        failedCanvas.SetActive(false);




        messageCanvas.OpenCanvasAgain();



    }
    public void ShowcleankitchenCanvas()
    {
        welcomeCanvas.SetActive(false);
        gasleakCanvas.SetActive(false);
        closegasleakCanvas.SetActive(false);
        checwholehouseCanvas.SetActive(false);
        findnozzleCanvas.SetActive(false);
        cleanlivingCanvas.SetActive(false);
        cleankitchenCanvas.SetActive(true);
        cleansecondhallwayCanvas.SetActive(false);
        cleanBedroomwallCanvas.SetActive(false);
        cleanbathroomCanvas.SetActive(false);
        findPlungerCanvas.SetActive(false);
        plungedtoiletCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(false);
        checkOutSideCanvas.SetActive(false);
        usePhoneCanvas.SetActive(false);
        dial1161Canvas.SetActive(false);
        successCanvas.SetActive(false);
        failedCanvas.SetActive(false);




        messageCanvas.OpenCanvasAgain();
    }

    public void ShowcleansecondhallwayCanvas()
    {

        welcomeCanvas.SetActive(false);
        gasleakCanvas.SetActive(false);
        closegasleakCanvas.SetActive(false);
        checwholehouseCanvas.SetActive(false);
        findnozzleCanvas.SetActive(false);
        cleanlivingCanvas.SetActive(false);
        cleankitchenCanvas.SetActive(false);
        cleansecondhallwayCanvas.SetActive(true);
        cleanBedroomwallCanvas.SetActive(false);
        cleanbathroomCanvas.SetActive(false);
        findPlungerCanvas.SetActive(false);
        plungedtoiletCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(false);
        checkOutSideCanvas.SetActive(false);
        usePhoneCanvas.SetActive(false);
        dial1161Canvas.SetActive(false);
        successCanvas.SetActive(false);
        failedCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }




    public void ShowcleanBedroomwallCanvas(bool show)
    {

        welcomeCanvas.SetActive(false);
        gasleakCanvas.SetActive(false);
        closegasleakCanvas.SetActive(false);
        checwholehouseCanvas.SetActive(false);
        findnozzleCanvas.SetActive(false);
        cleanlivingCanvas.SetActive(false);
        cleankitchenCanvas.SetActive(false);
        cleansecondhallwayCanvas.SetActive(false);
        cleanBedroomwallCanvas.SetActive(true);
        cleanbathroomCanvas.SetActive(false);
        findPlungerCanvas.SetActive(false);
        plungedtoiletCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(false);
        checkOutSideCanvas.SetActive(false);
        usePhoneCanvas.SetActive(false);
        dial1161Canvas.SetActive(false);
        successCanvas.SetActive(false);
        failedCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();

    }

    public void ShowcleanBedroomwallCanvas()
    {

        welcomeCanvas.SetActive(false);
        gasleakCanvas.SetActive(false);
        closegasleakCanvas.SetActive(false);
        checwholehouseCanvas.SetActive(false);
        findnozzleCanvas.SetActive(false);
        cleanlivingCanvas.SetActive(false);
        cleankitchenCanvas.SetActive(false);
        cleansecondhallwayCanvas.SetActive(false);
        cleanBedroomwallCanvas.SetActive(false);
        cleanbathroomCanvas.SetActive(true);
        findPlungerCanvas.SetActive(false);
        plungedtoiletCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(false);
        checkOutSideCanvas.SetActive(false);
        usePhoneCanvas.SetActive(false);
        dial1161Canvas.SetActive(false);
        successCanvas.SetActive(false);
        failedCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();

    }


    public void ShowfindPlungerCanvas()
    {
        welcomeCanvas.SetActive(false);
        gasleakCanvas.SetActive(false);
        closegasleakCanvas.SetActive(false);
        checwholehouseCanvas.SetActive(false);
        findnozzleCanvas.SetActive(false);
        cleanlivingCanvas.SetActive(false);
        cleankitchenCanvas.SetActive(false);
        cleansecondhallwayCanvas.SetActive(false);
        cleanBedroomwallCanvas.SetActive(false);
        cleanbathroomCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(false);
        findPlungerCanvas.SetActive(true);
        plungedtoiletCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(false);
        checkOutSideCanvas.SetActive(false);
        usePhoneCanvas.SetActive(false);
        dial1161Canvas.SetActive(false);
        successCanvas.SetActive(false);
        failedCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    public void ShowplungedtoiletCanvas()
    {
        welcomeCanvas.SetActive(false);
        gasleakCanvas.SetActive(false);
        closegasleakCanvas.SetActive(false);
        checwholehouseCanvas.SetActive(false);
        findnozzleCanvas.SetActive(false);
        cleanlivingCanvas.SetActive(false);
        cleankitchenCanvas.SetActive(false);
        cleansecondhallwayCanvas.SetActive(false);
        cleanBedroomwallCanvas.SetActive(false);
        cleanbathroomCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(false);
        checkOutSideCanvas.SetActive(false);
        findPlungerCanvas.SetActive(false);
        plungedtoiletCanvas.SetActive(true);
        usePhoneCanvas.SetActive(false);
        dial1161Canvas.SetActive(false);
        successCanvas.SetActive(false);
        failedCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    public void ShowgatherDirtyclothesCanvas()
    {
        welcomeCanvas.SetActive(false);
        gasleakCanvas.SetActive(false);
        closegasleakCanvas.SetActive(false);
        checwholehouseCanvas.SetActive(false);
        findnozzleCanvas.SetActive(false);
        cleanlivingCanvas.SetActive(false);
        cleankitchenCanvas.SetActive(false);
        cleansecondhallwayCanvas.SetActive(false);
        cleanBedroomwallCanvas.SetActive(false);
        cleanbathroomCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(true);
        checkOutSideCanvas.SetActive(false);
        findPlungerCanvas.SetActive(false);
        plungedtoiletCanvas.SetActive(false);
        usePhoneCanvas.SetActive(false);
        dial1161Canvas.SetActive(false);
        successCanvas.SetActive(false);
        failedCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }


    public void goCheckOutSideCanvas()
    {
        welcomeCanvas.SetActive(false);
        gasleakCanvas.SetActive(false);
        closegasleakCanvas.SetActive(false);
        checwholehouseCanvas.SetActive(false);
        findnozzleCanvas.SetActive(false);
        cleanlivingCanvas.SetActive(false);
        cleankitchenCanvas.SetActive(false);
        cleansecondhallwayCanvas.SetActive(false);
        cleanBedroomwallCanvas.SetActive(false);
        cleanbathroomCanvas.SetActive(false);
        findPlungerCanvas.SetActive(false);
        plungedtoiletCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(false);
        checkOutSideCanvas.SetActive(true);
        usePhoneCanvas.SetActive(false);
        dial1161Canvas.SetActive(false);
        successCanvas.SetActive(false);
        successCanvas.SetActive(false);
        failedCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    public void UsePhoneCanvas()
    {
        welcomeCanvas.SetActive(false);
        gasleakCanvas.SetActive(false);
        closegasleakCanvas.SetActive(false);
        checwholehouseCanvas.SetActive(false);
        findnozzleCanvas.SetActive(false);
        cleanlivingCanvas.SetActive(false);
        cleankitchenCanvas.SetActive(false);
        cleansecondhallwayCanvas.SetActive(false);
        cleanBedroomwallCanvas.SetActive(false);
        cleanbathroomCanvas.SetActive(false);
        findPlungerCanvas.SetActive(false);
        plungedtoiletCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(false);
        checkOutSideCanvas.SetActive(false);
        usePhoneCanvas.SetActive(true);
        dial1161Canvas.SetActive(false);
        successCanvas.SetActive(false);
        successCanvas.SetActive(false);
        failedCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }


    public void Showdial1161CanvasCanvas()
    {
        welcomeCanvas.SetActive(false);
        gasleakCanvas.SetActive(false);
        closegasleakCanvas.SetActive(false);
        checwholehouseCanvas.SetActive(false);
        findnozzleCanvas.SetActive(false);
        cleanlivingCanvas.SetActive(false);
        cleankitchenCanvas.SetActive(false);
        cleansecondhallwayCanvas.SetActive(false);
        cleanBedroomwallCanvas.SetActive(false);
        cleanbathroomCanvas.SetActive(false);
        findPlungerCanvas.SetActive(false);
        plungedtoiletCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(false);
        checkOutSideCanvas.SetActive(false);
        usePhoneCanvas.SetActive(false);
        dial1161Canvas.SetActive(true);
        successCanvas.SetActive(false);
        successCanvas.SetActive(false);
        failedCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }


    public void SuccessCanvas()
    {
        welcomeCanvas.SetActive(false);
        gasleakCanvas.SetActive(false);
        closegasleakCanvas.SetActive(false);
        checwholehouseCanvas.SetActive(false);
        findnozzleCanvas.SetActive(false);
        cleanlivingCanvas.SetActive(false);
        cleankitchenCanvas.SetActive(false);
        cleansecondhallwayCanvas.SetActive(false);
        cleanBedroomwallCanvas.SetActive(false);
        cleanbathroomCanvas.SetActive(false);
        findPlungerCanvas.SetActive(false);
        plungedtoiletCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(false);
        checkOutSideCanvas.SetActive(false);
        usePhoneCanvas.SetActive(false);
        dial1161Canvas.SetActive(false);
        successCanvas.SetActive(false);
        successCanvas.SetActive(true);
        failedCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    public void FailedCanvas()
    {
        welcomeCanvas.SetActive(false);
        gasleakCanvas.SetActive(false);
        closegasleakCanvas.SetActive(false);
        checwholehouseCanvas.SetActive(false);
        findnozzleCanvas.SetActive(false);
        cleanlivingCanvas.SetActive(false);
        cleankitchenCanvas.SetActive(false);
        cleansecondhallwayCanvas.SetActive(false);
        cleanBedroomwallCanvas.SetActive(false);
        cleanbathroomCanvas.SetActive(false);
        findPlungerCanvas.SetActive(false);
        plungedtoiletCanvas.SetActive(false);
        gatherDirtyclothesCanvas.SetActive(false);
        checkOutSideCanvas.SetActive(false);
        usePhoneCanvas.SetActive(false);
        dial1161Canvas.SetActive(false);
        successCanvas.SetActive(false);
        successCanvas.SetActive(false);
        failedCanvas.SetActive(true);
        messageCanvas.OpenCanvasAgain();
    }







    private void SetRoomBarrierColliderActive1(bool active)
    {
        roomBarrierCollider1.SetActive(active);
    }


    private void SetRoomBarrierColliderActive2(bool active)
    {
        roomBarrierCollider2.enabled = active;
    }


    private void SetRoomBarrierColliderActive3(bool active)
    {
        roomBarrierCollider3.enabled = active;
    }

    private void SetRoomBarrierColliderActive4(bool active)
    {
        roomBarrierCollider4.enabled = active;
    }


    // Add any new canvas switch functions here
    public IEnumerator SwitchCanvasAfterDelay()
    {
        // Wait for the specified time
        yield return new WaitForSeconds(switchDelayWelcome);
        ShowgasleakCanvasCanvas();
    }


    public void FinishCanvas()
    {
        SetRoomBarrierColliderActive1(false);
    }


  





}