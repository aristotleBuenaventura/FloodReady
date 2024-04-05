using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calling_UI_HTP : MonoBehaviour
{
    public AudioSource call;
    // Start is called before the first frame update
    void Start()
    {
        call.Play();

        StartCoroutine(DelayedAction());
    }

    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(5f);

    }
}
