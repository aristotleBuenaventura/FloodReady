using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.tvOS;

public class CanvasControllerFirstCanvasHTP : MonoBehaviour
{
    public GameObject welcomeCanvas;
    public GameObject ViewCheckList;
    public GameObject ProceedHouse;
    public float switchDelayWelcome = 10f;
    public GameObject HTPTrainingRoomChecklist;


    private void Start()
    {
        // Ensure both canvases start in the desired state
        ShowWelcomeCanvas();
        StartCoroutine(SwitchCanvasAfterDelay());
  
    }

    public void ShowWelcomeCanvas()
    {
        welcomeCanvas.SetActive(true);
        ViewCheckList.SetActive(false);
        ProceedHouse.SetActive(false);
        HTPTrainingRoomChecklist.SetActive(true);

    }


    public void ShowViewCheckList()
    {
        welcomeCanvas.SetActive(false);
        ViewCheckList.SetActive(true);
        ProceedHouse.SetActive(false);

    }

    public void ShowProceedHouseCanvas()
    {
        welcomeCanvas.SetActive(false);
        ViewCheckList.SetActive(false);
        ProceedHouse.SetActive(true);

    }  // Start is called before the first frame update

    public void HideAllCanvas()
    {
        {
            welcomeCanvas.SetActive(false);
            ViewCheckList.SetActive(false);
            ProceedHouse.SetActive(false);
        }
    }

    private IEnumerator SwitchCanvasAfterDelay()
    {
        // Wait for the specified time
        yield return new WaitForSeconds(switchDelayWelcome);

        // Switch to the TVCanvas
        ShowViewCheckList();
    }

}
