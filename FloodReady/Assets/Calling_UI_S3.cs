using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calling_UI_S3 : MonoBehaviour
{
    public AudioSource call;
    // Start is called before the first frame update
    public reportfallenIcon reportIcon;
    public RecoveryCanvasController success;
    public GameObject portal;
    public DialScene3Icon checklist;

    void Start()
    {
        call.Play();

        StartCoroutine(DelayedAction());
        
    }

    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(9f);
        reportIcon.SetCheckIconVisible(true);
        reportIcon.SetUncheckIconVisible(false);
        checklist.SetCheckIconVisible(true);
        checklist.SetUncheckIconVisible(false);
        success.Showdial1161CanvasCanvas();
        StartCoroutine(CirclePoint());

    }

    IEnumerator CirclePoint()
    {
        yield return new WaitForSeconds(6f);
        success.ShowdialCirclePointCanvasCanvas();
        portal.SetActive(true);

    }
}
