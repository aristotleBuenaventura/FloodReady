using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseHintHTP : MonoBehaviour
{
    public GameObject objectToShow;
    public ShowHintHTP ShowHintHTP;
    public GameObject[] hintIcons;

    private void Start()
    {
        objectToShow.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            objectToShow.SetActive(false);
            ShowHintHTP.HideAllCanvas();

            foreach (GameObject obj in hintIcons)
            {
                if (obj != null) // Check if the GameObject reference is not null
                {
                    obj.SetActive(false);
                }
            }
        }
    }
}
