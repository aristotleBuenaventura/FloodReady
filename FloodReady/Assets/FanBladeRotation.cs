using UnityEngine;

public class RotateVRObject : MonoBehaviour
{
    public float rotationSpeed = 1000.0f;
    public bool shouldRotate = true;

    void Update()
    {
        if (shouldRotate)
        {
            transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
        }
    }
}
