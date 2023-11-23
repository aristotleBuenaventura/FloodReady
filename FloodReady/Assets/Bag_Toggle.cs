using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag_Toggle : MonoBehaviour
{
    public GameObject bag; // Note the corrected type of GameObject

    private void Start()
    {
        bag.SetActive(false); // Use SetActive instead of enabled for GameObject
    }

    // Update is called once per frame
    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two)) // You can replace this with the Oculus button you want to use.
        {
            bag.SetActive(!bag.activeSelf); // Toggle the GameObject's active state.
        }
    }
}
