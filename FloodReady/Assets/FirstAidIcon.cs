using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAidIcon : MonoBehaviour
{
    public GameObject checkIcon;
    public GameObject uncheckIcon;

    private void Start()
    {
        // By default, set the check icon to be visible and the uncheck icon to be hidden
        SetCheckIconVisible(false);
        SetUncheckIconVisible(true);
    }

    // Function to set the check icon to be visible and the uncheck icon to be hidden
    public void SetCheckIconVisible(bool isVisible)
    {
        checkIcon.SetActive(isVisible);
    }

    // Function to set the uncheck icon to be visible and the check icon to be hidden
    public void SetUncheckIconVisible(bool isVisible)
    {
        uncheckIcon.SetActive(isVisible);
    }
}
