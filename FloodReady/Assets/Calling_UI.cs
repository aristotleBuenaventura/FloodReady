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

    // Start is called before the first frame update
    void Start()
    {
        call.Play();
        
        StartCoroutine(DelayedAction());
    }

    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(5f);

        welldone.WelldoneCanvas();
        icon161.SetCheckIconVisible(true);
        icon161.SetUncheckIconVisible(false);
        portal.SetActive(true);
        boat.SetActive(true);
    }
}
