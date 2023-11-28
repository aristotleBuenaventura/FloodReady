using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeCanvasController : MonoBehaviour
{
    // Add any new canvas references here
    public GameObject welcomeCanvas;
    public GameObject retrieveGoBagCanvas;
    public GameObject mainBreakerCanvas;
    public GameObject doorJamCanvas;
    public GameObject pryBarCanvas;
    public GameObject breakWindowCanvas;
    public GameObject searchGoBagCanvas;
    public GameObject welldoneCanvas;
    public MessageCanvas messageCanvas;
    public float switchDelayWelcome = 15f;
    

    // Add the switch delay for the RetrieveGoBagCanvas
    public float switchDelayRetrieveGoBag = 10f;
    public BoxCollider roomBarrierCollider1;
    public BoxCollider roomBarrierCollider2;
    public BoxCollider roomBarrierCollider3;
    public BoxCollider roomBarrierCollider4;


    private void Start()
    {
        // Ensure the welcome canvas starts in the desired state
        ShowWelcomeCanvas();

        // Start the coroutine to switch canvases after a delay
        StartCoroutine(SwitchCanvasAfterDelay());
    }

    // Add any new canvas show functions here
    private void ShowWelcomeCanvas()
    {
        welcomeCanvas.SetActive(true);
        retrieveGoBagCanvas.SetActive(false);
        mainBreakerCanvas.SetActive(false);
        doorJamCanvas.SetActive(false);
        pryBarCanvas.SetActive(false);
        breakWindowCanvas.SetActive(false);
        searchGoBagCanvas.SetActive(false);
        welldoneCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    public void ShowRetrieveGoBagCanvas()
    {
        welcomeCanvas.SetActive(false);
        retrieveGoBagCanvas.SetActive(true);
        mainBreakerCanvas.SetActive(false);
        doorJamCanvas.SetActive(false);
        pryBarCanvas.SetActive(false);
        breakWindowCanvas.SetActive(false);
        searchGoBagCanvas.SetActive(false);
        welldoneCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    public void ShowMainBreakerCanvas()
    {
        welcomeCanvas.SetActive(false);
        retrieveGoBagCanvas.SetActive(false);
        mainBreakerCanvas.SetActive(true);
        doorJamCanvas.SetActive(false);
        pryBarCanvas.SetActive(false);
        breakWindowCanvas.SetActive(false);
        searchGoBagCanvas.SetActive(false);
        welldoneCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
        SetRoomBarrierColliderActive2(false);

    }

    public void ShowdoorJamCanvas()
    {
        welcomeCanvas.SetActive(false);
        retrieveGoBagCanvas.SetActive(false);
        mainBreakerCanvas.SetActive(false);
        doorJamCanvas.SetActive(false);
        pryBarCanvas.SetActive(false);
        breakWindowCanvas.SetActive(false);
        searchGoBagCanvas.SetActive(false);
        welldoneCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    public void ShowPryBarCanvas()
    {
        welcomeCanvas.SetActive(false);
        retrieveGoBagCanvas.SetActive(false);
        mainBreakerCanvas.SetActive(false);
        doorJamCanvas.SetActive(false);
        pryBarCanvas.SetActive(true);
        breakWindowCanvas.SetActive(false);
        searchGoBagCanvas.SetActive(false);
        welldoneCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    public void ShowBreakWindowCanvas()
    {
        welcomeCanvas.SetActive(false);
        retrieveGoBagCanvas.SetActive(false);
        mainBreakerCanvas.SetActive(false);
        doorJamCanvas.SetActive(false);
        pryBarCanvas.SetActive(false);
        breakWindowCanvas.SetActive(true);
        searchGoBagCanvas.SetActive(false);
        welldoneCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

 
    public void ShowSearchGoBagCanvas()
    {
        welcomeCanvas.SetActive(false);
        retrieveGoBagCanvas.SetActive(false);
        mainBreakerCanvas.SetActive(false);
        doorJamCanvas.SetActive(false);
        pryBarCanvas.SetActive(false);
        breakWindowCanvas.SetActive(false);
        searchGoBagCanvas.SetActive(true);
        welldoneCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
    }

    public void WelldoneCanvas()
    {
        welcomeCanvas.SetActive(false);
        retrieveGoBagCanvas.SetActive(false);
        mainBreakerCanvas.SetActive(false);
        doorJamCanvas.SetActive(false);
        pryBarCanvas.SetActive(false);
        breakWindowCanvas.SetActive(false);
        searchGoBagCanvas.SetActive(false);
        welldoneCanvas.SetActive(true);
        messageCanvas.OpenCanvasAgain();
    }



    private void SetRoomBarrierColliderActive1(bool active)
    {
        roomBarrierCollider1.enabled = active;
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
     
         

            // Wait for the specified time before switching to the RetrieveGoBagCanvas
            yield return new WaitForSeconds(switchDelayRetrieveGoBag);

            // Switch to the RetrieveGoBagCanvas
            ShowRetrieveGoBagCanvas();
        SetRoomBarrierColliderActive1(false);


    }

    public void FinishCanvas()
    {
        SetRoomBarrierColliderActive1(false);
    }
}
