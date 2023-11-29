using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proceedToggleOff : MonoBehaviour
{
    public GameObject proceedButton;
    public GameObject tryagainButton;

    void Start(){
        win();
    }
    
    public void win(){
        proceedButton.SetActive(true);
        tryagainButton.SetActive(false);
    }

    public void lose(){
        proceedButton.SetActive(false);
        tryagainButton.SetActive(true);
    }
}
