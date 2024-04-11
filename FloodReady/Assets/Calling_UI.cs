using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calling_UI : MonoBehaviour
{
    public AudioSource call;
    public EscapeCanvasController welldone;
    public iconfordial161 icon161;
    public GameObject portal;
    public GameObject boat;
    public GameObject hintDial61;
    public AudioSource Father;
    // Start is called before the first frame update
    void Start()
    {
        Father.Play();
        
        
        StartCoroutine(DelayedAction());
    }

    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(7f);
        StartCoroutine(DelayedActionFather());
        call.Play();
        
    }

    

    IEnumerator DelayedActionFather()
    {
        yield return new WaitForSeconds(5f);

        Destroy(hintDial61);
        welldone.WelldoneCanvas();
        icon161.SetCheckIconVisible(true);
        icon161.SetUncheckIconVisible(false);
        portal.SetActive(true);
        boat.SetActive(true);
    }


}
