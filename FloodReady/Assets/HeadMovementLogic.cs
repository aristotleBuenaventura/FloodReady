using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMovementLogic : MonoBehaviour
{
    public GameObject cameraHead;
    public HeadMovementIcon LU;
    public HeadMovementIcon LD;
    public HeadMovementIcon LL;
    public HeadMovementIcon LR;
    public HeadMovementIcon TL;
    public HeadMovementIcon TR;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Get the Euler angles from the rotation quaternion
        float xRotation = cameraHead.transform.rotation.eulerAngles.x;
        float yRotation = cameraHead.transform.rotation.eulerAngles.y;
        float zRotation = cameraHead.transform.rotation.eulerAngles.z;
        Debug.Log("x: " + xRotation + " y: " + yRotation + " z: " + zRotation);

        // Check the rotation around the z-axis
        if (xRotation >= 300f && xRotation <= 320f)
        {
            LU.SetCheckIconVisible(true);
            LU.SetUncheckIconVisible(false);
        }
        
        if (xRotation >= 60f && xRotation <= 75f)
        {
            LD.SetCheckIconVisible(true);
            LD.SetUncheckIconVisible(false);
        }
        
        if (yRotation >= 100f && yRotation <= 110f)
        {
            LL.SetCheckIconVisible(true);
            LL.SetUncheckIconVisible(false);
        }
        
        if (yRotation >= 250f && yRotation <= 260f)
        {
            LR.SetCheckIconVisible(true);
            LR.SetUncheckIconVisible(false);
        }
        
        if (zRotation >= 70f && zRotation <= 80f)
        {
            TL.SetCheckIconVisible(true);
            TL.SetUncheckIconVisible(false);
        }
        
        if (zRotation >= 280f && zRotation <= 290f)
        {
            TR.SetCheckIconVisible(true);
            TR.SetUncheckIconVisible(false);
        }
    }
}
