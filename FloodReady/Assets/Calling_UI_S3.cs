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
        portal.SetActive(true);
        success.Showdial1161CanvasCanvas();

    }
}
