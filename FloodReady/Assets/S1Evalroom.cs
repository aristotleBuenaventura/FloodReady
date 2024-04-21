using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S1Evalroom : MonoBehaviour
{
    public Vector3 desiredPosition;
    public Vector3 desiredRotation;
    public GameObject evalroom;
    // Start is called before the first frame update


    public void TeleportRoom()
    {
        if (evalroom != null)
        {

            // Set the desired position from the Inspector
            evalroom.transform.position = desiredPosition;

            // Set the desired rotation from the Inspector
            evalroom.transform.rotation = Quaternion.Euler(desiredRotation);


        }
    }
}
