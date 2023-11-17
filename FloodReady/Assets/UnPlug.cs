using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnPlug : MonoBehaviour
{
    public RotateVRObject rotateVRObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Plug"))
        {
            RotateVRObject.SetShouldRotate(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Plug"))
        {
            RotateVRObject.SetShouldRotate(false);
        }
    }
}
