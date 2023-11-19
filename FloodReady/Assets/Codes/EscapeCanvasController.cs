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
    public MessageCanvas messageCanvas;
    public float switchDelayWelcome = 15f;
    

    // Add the switch delay for the RetrieveGoBagCanvas
    public float switchDelayRetrieveGoBag = 10f;

   

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
        messageCanvas.OpenCanvasAgain();
    }

    public void ShowdoorJamCanvas()
    {
        welcomeCanvas.SetActive(false);
        retrieveGoBagCanvas.SetActive(false);
        mainBreakerCanvas.SetActive(true);
        doorJamCanvas.SetActive(true);
        pryBarCanvas.SetActive(false);
        breakWindowCanvas.SetActive(false);
        searchGoBagCanvas.SetActive(false);
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
        messageCanvas.OpenCanvasAgain();
    }


    // Add any new canvas switch functions here
    public IEnumerator SwitchCanvasAfterDelay()
    {
     
         

            // Wait for the specified time before switching to the RetrieveGoBagCanvas
            yield return new WaitForSeconds(switchDelayRetrieveGoBag);

            // Switch to the RetrieveGoBagCanvas
            ShowRetrieveGoBagCanvas();

       
    }

    // Add similar functions for other canvases

    // ...
}
