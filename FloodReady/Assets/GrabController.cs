using UnityEngine;

public class GrabController : MonoBehaviour
{
    public float fixedRotationX = 45f;
    public float fixedRotationY = 0f;
    public float fixedRotationZ = 0f;

    private bool isGrabbed = false;

    // Update is called once per frame
    void Update()
    {
        if (isGrabbed)
        {
            // Adjust the rotation of the grabbed object
            transform.rotation = Quaternion.Euler(fixedRotationX, fixedRotationY, fixedRotationZ);
        }
    }

    // Your grab function should set isGrabbed to true when grabbing starts
    public void GrabStart()
    {
        isGrabbed = true;
    }

    // Your release function should set isGrabbed to false when grabbing ends
    public void GrabEnd()
    {
        isGrabbed = false;
    }
}